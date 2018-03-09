using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFTutorial.DataBinding;
using WPFTutorial.Commands;
using WPFTutorial.Dialogs;
using WPFTutorial.Common_interface_controls;
using WPFTutorial.Rich_text_controls;
using WPFTutorial.TreeView_Control;
using WPFTutorial.IU;
using WPFTutorial.Style;
using WPFTutorial.Misc;
using WPFTutorial.Audio_and_Video;

namespace WPFTutorial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
         
        public void OpenFile(String nombreArchivo)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ExtendedResourceSample modal = new ExtendedResourceSample();
            //ExceptionHandlingSample modal = new ExceptionHandlingSample();
            //TextBlockSample modal = new TextBlockSample();
            //LabelControlSample modal = new LabelControlSample();
            //TextBoxSelectionSample modal = new TextBoxSelectionSample();
            //CheckBoxSample modal = new CheckBoxSample();
            //RadioButtonSample modal = new RadioButtonSample();
            //PasswordBoxSample modal = new PasswordBoxSample();
            //ToolTipsAdvancedSample modal = new ToolTipsAdvancedSample();
            //TextRenderingModeSample modal = new TextRenderingModeSample();
            //Canvas modal = new Canvas();
            //WrapPanel modal = new WrapPanel();
            //StackPanel modal = new StackPanel();
            //GridSample modal = new GridSample();
            //TabularGrid modal = new TabularGrid();
            //GridUnits modal = new GridUnits();
            //GridColRowSpan modal = new GridColRowSpan();
            //GridColRowSpanAdvanced modal = new GridColRowSpanAdvanced();
            //GridSplitterSample modal = new GridSplitterSample();
            //GridSplitterHorizontalSample modal = new GridSplitterHorizontalSample();
            //GridContactForm modal = new GridContactForm();
            //GridContactFormTake2 modal = new GridContactFormTake2();
            //HelloBoundWorldSample modal = new HelloBoundWorldSample();
            //DataContextSample modal = new DataContextSample();
            //ChangeNotificationSample modal = new ChangeNotificationSample();
            //ConverterSample modal = new ConverterSample();
            //DataBindingDebuggingSample modal = new DataBindingDebuggingSample();
            //UsingCommandsSample modal = new UsingCommandsSample();
            //CommandCanExecuteSample modal = new CommandCanExecuteSample();
            //CustomCommandSample modal = new CustomCommandSample();
            //MessageBoxSample modal = new MessageBoxSample();
            //OpenFileDialogSample modal = new OpenFileDialogSample();
            //OpenFileDialogMultipleFilesSample modal = new OpenFileDialogMultipleFilesSample();
            //SaveFileDialogSample modal = new SaveFileDialogSample();
            //InputDialogSample modal = new InputDialogSample("¿ Cómo se hace el pan de elote?","Con ganas");
            //InputDialogAppSample modal = new InputDialogAppSample();
            //MenuSample modal = new MenuSample();
            //MenuIconCheckableSample modal = new MenuIconCheckableSample();
            //MenuWithCommandsSample modal = new MenuWithCommandsSample();
            //ContextMenuSample modal = new ContextMenuSample();
            //ContextMenuWithCommandsSample modal = new ContextMenuWithCommandsSample();
            //ContextMenuManuallyInvokedSample modal = new ContextMenuManuallyInvokedSample();
            //ToolbarSample modal = new ToolbarSample();
            //ToolbarIconSample modal = new ToolbarIconSample();
            //ToolbarPositionSample modal = new ToolbarPositionSample();
            //ToolbarCustomControlsSample modal = new ToolbarCustomControlsSample();
            //RibbonBar modal = new RibbonBar();
            StatusBarSample modal = new StatusBarSample();
            //StatusBarAdvancedSample modal = new StatusBarAdvancedSample();
            //FlowDocumentScrollViewerSample modal = new FlowDocumentScrollViewerSample();
            //FlowDocumentScrollViewerZoomSample modal = new FlowDocumentScrollViewerZoomSample();
            //FlowDocumentTextAlignmentSample modal = new FlowDocumentTextAlignmentSample();
            //FlowDocumentPageViewerSample modal = new FlowDocumentPageViewerSample();
            //FlowDocumentSearchSample modal = new FlowDocumentSearchSample();
            //FlowDocumentReaderSample modal = new FlowDocumentReaderSample();
            //TreeViewSample modal = new TreeViewSample();
            //TreeViewCustomItemsSample modal = new TreeViewCustomItemsSample();
            //TreeViewDataBindingSample modal = new TreeViewDataBindingSample();
            //TreeViewMultipleTemplatesSample modal = new TreeViewMultipleTemplatesSample();
            //TreeViewSelectionExpansionSample modal = new TreeViewSelectionExpansionSample();
            //TreeViewDinamicos modal = new TreeViewDinamicos();
            //TreeViewColeccion modal = new TreeViewColeccion();
            //LazyLoadingSample modal = new LazyLoadingSample();
            //DGGroupSortFilterExample.MainWindow modal = new DGGroupSortFilterExample.MainWindow();
            //WindowWideStyleSample modal = new WindowWideStyleSample();
            //ExplicitStyleSample modal = new ExplicitStyleSample();
            //StyleTriggersSample modal = new StyleTriggersSample();
            //StyleDataTriggerSample modal = new StyleDataTriggerSample();
            //StyleEventTriggerSample modal = new StyleEventTriggerSample();
            //StyleMultiTriggerSample modal = new StyleMultiTriggerSample();
            //StyleMultiDataTriggerSample modal = new StyleMultiDataTriggerSample();
            //StyleTriggerEnterExitActions modal = new StyleTriggerEnterExitActions();
            //BackgroundWorkerSample modal = new BackgroundWorkerSample();
            //BackgroundWorkerCancellationSample modal = new BackgroundWorkerCancellationSample();
            //SpeechSynthesisPromptBuilderSample modal = new SpeechSynthesisPromptBuilderSample();
            //SpeechRecognitionApp modal = new SpeechRecognitionApp();
            modal.Owner = this;
            modal.ShowDialog();
        }
    }
}
