   M S B A M L   `   `   `  ����  WPFTutorial    WPFTutorial.IU.RibbonBar   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  	RibbonBar��5   	   $	��300��6   $	��300��6(   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   5      .+�5
   
   +  %System.Windows.Controls.Ribbon.Ribbon  -   5          Name$ RibbonGeneral��5
       �� SelectedIndex$ 0��6(      HelpPaneContent 5      1  +System.Windows.Controls.Ribbon.RibbonButton  5         SmallImageSource$ /Images/Help.png��6      QuickAccessToolBar 5      =  7System.Windows.Controls.Ribbon.RibbonQuickAccessToolBar  5      .@�5        -   5          Name$
 Save��5   #   $ /Images/ok.png��62   6  0System.Windows.Controls.Ribbon.RibbonSplitButton  5      -   5          Name$
 Undo��5   (   5  /System.Windows.Controls.Ribbon.RibbonMenuButton	   SmallImageSource$	 /Images/undo.png��67   .@�5      8  2System.Windows.Controls.Ribbon.RibbonSplitMenuItem  $��Undo 1��6.     5      $��Undo 2��6.     5      $��Undo 3��6.   5        5      -   5        $
 Redo��5   (   $	 /Images/redo.png��66   .@�5        $��Redo 1��6.     5      $��Redo 2��6.   5      5      
   ApplicationMenu
 5      :  4System.Windows.Controls.Ribbon.RibbonApplicationMenu  5          KeyTip$ F��6(   .@�5!      >  8System.Windows.Controls.Ribbon.RibbonApplicationMenuItem  $��Options��60   3	  -System.Windows.Controls.Ribbon.RibbonMenuItem 	  ImageSource$ /Images/folder.png��6A     5"      $
��Exit��60   $ /Images/close.png��6>   5#      .@�5&      .
  (System.Windows.Controls.Ribbon.RibbonTab
  $
��Home��6    
  KeyTip$ H��6&   .@�5(      0  *System.Windows.Controls.Ribbon.RibbonGroup  -   5          Name$ ClipboardGroup��5(      $
��Home��66   .@�5)           LargeImageSource$ /Images/paste.png��6'      Label$ Paste��6L   $ V��6Z   .@�5*      	  $ /Images/paste.png��6)   $��Keep Text Only��6I    	  KeyTip$ T��6a   	  5+      $ /Images/paste.png��6)   $��Paste Special...��6I   $ S��6c   5,        5-      $ /Images/cut.png��6#      Label$	 Cut��6F      KeyTip$ X��6R     5.      $ /Images/copy.png��6#   $
 Copy��6G   $ C��6T     5/      $ /Images/Help.png��6#   $ Format Painter��6G   $ FP��6^   50        52      -   5        $ Employee��52      $��Employee And Payroll��60   .@�53        $ /Images/family.png��6'   $ Employee��6M   $ V��6^   .@�54      	  $ /Images/paste.png��6)   $��Keep Text Only��6I   $ T��6a   	  55      $ /Images/paste.png��6)   $��Paste Special...��6I   $ S��6c   56        57      $ /Images/save.png��6#   $
 Save��6G   $ X��6T     58      $ /Images/ok.png��6#   $	 Add��6E   $ C��6Q   59      5:      
  5<      $��Insert��6   $ I��6(   5=      
  5?      $��
PageLayout��6   $ L��6,   5@      5A      5C      5D      