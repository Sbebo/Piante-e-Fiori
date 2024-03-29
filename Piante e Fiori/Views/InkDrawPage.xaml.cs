﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

using Piante_e_Fiori.Services.Ink;
using Piante_e_Fiori.Services.Ink.UndoRedo;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Piante_e_Fiori.Views
{
    // For more information regarding Windows Ink documentation and samples see https://github.com/Microsoft/WindowsTemplateStudio/blob/master/docs/pages/ink.md
    public sealed partial class InkDrawPage : Page, INotifyPropertyChanged
    {
        private InkStrokesService strokeService;
        private InkLassoSelectionService lassoSelectionService;
        private InkPointerDeviceService pointerDeviceService;
        private InkCopyPasteService copyPasteService;
        private InkUndoRedoService undoRedoService;
        private InkFileService fileService;
        private InkZoomService zoomService;

        public InkDrawPage()
        {
            InitializeComponent();
            Loaded += (sender, eventArgs) =>
            {
                SetCanvasSize();

                strokeService = new InkStrokesService(inkCanvas.InkPresenter);
                var selectionRectangleService = new InkSelectionRectangleService(inkCanvas, selectionCanvas, strokeService);
                lassoSelectionService = new InkLassoSelectionService(inkCanvas, selectionCanvas, strokeService, selectionRectangleService);
                pointerDeviceService = new InkPointerDeviceService(inkCanvas);
                copyPasteService = new InkCopyPasteService(strokeService);
                undoRedoService = new InkUndoRedoService(inkCanvas, strokeService);
                fileService = new InkFileService(inkCanvas, strokeService);
                zoomService = new InkZoomService(canvasScroll);

                touchInkingButton.IsChecked = true;
                mouseInkingButton.IsChecked = true;

                strokeService.CopyStrokesEvent += (s, e) => RefreshEnabledButtons();
                strokeService.SelectStrokesEvent += (s, e) => RefreshEnabledButtons();
                strokeService.ClearStrokesEvent += (s, e) => RefreshEnabledButtons();
                undoRedoService.UndoEvent += (s, e) => RefreshEnabledButtons();
                undoRedoService.RedoEvent += (s, e) => RefreshEnabledButtons();
                undoRedoService.AddUndoOperationEvent += (s, e) => RefreshEnabledButtons();
                pointerDeviceService.DetectPenEvent += (s, e) => touchInkingButton.IsChecked = false;
            };
        }

        private void SetCanvasSize()
        {
            inkCanvas.Width = Math.Max(canvasScroll.ViewportWidth, 1000);
            inkCanvas.Height = Math.Max(canvasScroll.ViewportHeight, 1000);
        }

        private void LassoSelection_Checked(object sender, RoutedEventArgs e) => lassoSelectionService?.StartLassoSelectionConfig();

        private void LassoSelection_Unchecked(object sender, RoutedEventArgs e) => lassoSelectionService?.EndLassoSelectionConfig();

        private void TouchInking_Checked(object sender, RoutedEventArgs e) => pointerDeviceService.EnableTouch = true;

        private void TouchInking_Unchecked(object sender, RoutedEventArgs e) => pointerDeviceService.EnableTouch = false;

        private void MouseInking_Checked(object sender, RoutedEventArgs e) => pointerDeviceService.EnableMouse = true;

        private void MouseInking_Unchecked(object sender, RoutedEventArgs e) => pointerDeviceService.EnableMouse = false;

        private void ZoomIn_Click(object sender, RoutedEventArgs e) => zoomService?.ZoomIn();

        private void ZoomOut_Click(object sender, RoutedEventArgs e) => zoomService?.ZoomOut();

        private void Copy_Click(object sender, RoutedEventArgs e) => copyPasteService?.Copy();

        private void Cut_Click(object sender, RoutedEventArgs e)
        {
            copyPasteService?.Cut();
            ClearSelection();
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            copyPasteService?.Paste();
            ClearSelection();
        }

        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            ClearSelection();
            undoRedoService?.Undo();
        }

        private void Redo_Click(object sender, RoutedEventArgs e)
        {
            ClearSelection();
            undoRedoService?.Redo();
        }

        private async void LoadInkFile_Click(object sender, RoutedEventArgs e)
        {
            ClearSelection();
            var fileLoaded = await fileService?.LoadInkAsync();

            if (fileLoaded)
            {
                undoRedoService?.Reset();
            }
        }

        private async void SaveInkFile_Click(object sender, RoutedEventArgs e)
        {
            ClearSelection();
            await fileService?.SaveInkAsync();
        }

        private async void ExportAsImage_Click(object sender, RoutedEventArgs e)
        {
            ClearSelection();
            await fileService?.ExportToImageAsync();
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            var strokes = strokeService?.GetStrokes().ToList();
            ClearSelection();
            strokeService?.ClearStrokes();
            undoRedoService?.AddOperation(new RemoveStrokeUndoRedoOperation(strokes, strokeService));
        }

        private void RefreshEnabledButtons()
        {
            CutButton.IsEnabled = copyPasteService.CanCut;
            CopyButton.IsEnabled = copyPasteService.CanCopy;
            PasteButton.IsEnabled = copyPasteService.CanPaste;
            UndoButton.IsEnabled = undoRedoService.CanUndo;
            RedoButton.IsEnabled = undoRedoService.CanRedo;
            SaveInkFileButton.IsEnabled = strokeService.GetStrokes().Any();
            ExportAsImageButton.IsEnabled = strokeService.GetStrokes().Any();
            ClearAllButton.IsEnabled = strokeService.GetStrokes().Any();
        }

        private void ClearSelection() => lassoSelectionService?.ClearSelection();

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        //DUPLICA FINESTRA
        private async void duplica_finestra_btn_Click(object sender, RoutedEventArgs e)
        {
            Windows.ApplicationModel.Core.CoreApplicationView newView = CoreApplication.CreateNewView();
            int newViewId = 0;
            await newView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Frame frame = new Frame();
                frame.Navigate(typeof(InkDrawPage), null);
                Window.Current.Content = frame;
                // You have to activate the window in order to show it later.
                Window.Current.Activate();

                newViewId = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().Id;
            });
            bool viewShown = await ApplicationViewSwitcher.TryShowAsStandaloneAsync(newViewId);
        }
    }
}
