   M S B A M L   `   `   `  ����P  LDataGridFilterLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\Bclr-namespace:DataGridFilterLibrary;assembly=DataGridFilterLibraryDataGridFilterLibrary  5   	    Catalogos_BI_Fase_I'   !Catalogos_BI_Fase_I.MenuPrincipal   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   UfilterBclr-namespace:DataGridFilterLibrary;assembly=DataGridFilterLibrary     5   	     � Title$  Catalogos generales��5   	   $
��Auto��6%   $
��AUTO��63   .��5      �� $��0,0,2,0q�6    J� RenderTransformOrigin$ 0.466,0.492&�6"   .+�5	   
   +  %System.Windows.Controls.Ribbon.Ribbon  -   5          Name$ 
mainRibbon��5	      .@�5
      .  (System.Windows.Controls.Ribbon.RibbonTab  $��Mantenimientos��6   .@�5      0  *System.Windows.Controls.Ribbon.RibbonGroup  -   5          Name$ Group1��5      $��Acciones��6.   .@�5      1  +System.Windows.Controls.Ribbon.RibbonButton  -   5        $��rbNuevo��5   #      Label$ Nuevo��62      LargeImageSource$ /Imagenes/nuevo.png��6@   6g     5      -   5        $��
rbEliminar��5   #   $ Eliminar��65   $ /Imagenes/delete.png��6F   6n   5        5      -   5        $ 	Generales��5      $��	Generales��61   .@�5        -   5        $��rbSalir��5   #   $ Salir��62   $ /Imagenes/exit.png��6@   6f   5      5        5      $��Reportes��6   .@�5        -   5        $ Group2��5      $��Lista de Reportes��6.   .@�5        $ Imprimir��6#   $ /Imagenes/printer.png��64   5      5      5      � 5   
    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��5 �6#   �� 5       $��* �6#    � RowDefinitions 5"      �� 5#      $	��192 �6!   �� 5$      $��* �6!   .+�5&      �� $��0��6   $
��Left=�6&   $	��192��6A   $	��Top=�6N   .+�5'      9� -   5         9�Name$ 	Expander1��5'   8   
����İ�$��Contabilidad��6K   $��0,0,6,0q�6a   $ 0.5,0.5&�6r   z�5)      V� 5*      .~�5+      �� �� 5,      �� 5-      	 �� Angle$	 359.821Q�6.   T� 5.      
 T� X$
 -0.072Q�61   5/      .��51      �� -	   5        $��listBContabilidad��51      
�������.@�52      �� .��53      �� �� 6)   $&� DWD_Criterio_EdoResultados_41501��6-   6X   54      �� 55      .��56      �� �� 6)   $)�#DWD_Criterio_EdoResultados_Especial��6-   6[   57      �� 58      .��59      �� �� 6)   $ �DWD_Emp_Reporte_Utilidades��6-   6R   5:      �� 5;      .��5<      �� �� 6)   $�d_acreedor_operadora��6-   6L   5=      �� 5>      .��5?      �� �� 6)   $�d_deudor_operadora��6-   6J   5@      �� 5A      .��5B      �� �� 6)   $�DWD_Gpo_Cuenta_Balance��6-   6N   5C      �� 5D      .��5E      �� �� 6)   $.�(DWD_Gpo_Cuenta_EdoResultados_Tradicional��6-   6`   5F      �� 5G      .��5H      �� �� 6)   $&� DWD_Gpo_Cuenta_Balance_Operadora��6-   6X   5I      5J      5L      9� 5N      -
   5        $ 	Expander3��5N   7   
����İ�$��Segunda etapa��6J   $��0,0,6,0q�6a   $ 0.5,0.5&�6r   z�5O      V� 5P      .~�5Q      �� �� 5R      �� 5S      $	 359.821Q�6.   T� 5T      $
 0.072Q�61   5U      .��5W      �� -   5         ��Name$ listbox2��5W   5   
�������.@�5X      �� .��5Y      �� �� 6)   $
�SEG1��6-   6<   5Z      �� 5[      .��5\      �� �� 6)   $
�SEG2��6-   6<   5]      5^      5_      9� 5`      -   5        $ 	Expander2��5`   7   
����İ�$��Tercera etapa  ��6J   $��0,0,6,0q�6c   $ 0.5,0.5&�6t   z�5a      V� 5b      .~�5c      �� �� 5d      �� 5e      $	 359.821Q�6.   T� 5f      $
 0.072Q�61   5g      .��5i      �� -   5        $ listbox3��5i   5   
�������.@�5j      �� .��5k      �� �� 6)   $
�TER1��6-   6<   5l      �� 5m      $��20��6&   .��5n      �� �� 6)   $
�Ter2��6-   6<   5o      5p      5q      5r      �� 5s      $��1��6   $��5��6+   $��Stretch=�65   &   System.Windows.Controls.DataGrid  5t      -   5        $��grd_General��5t   8   $��2��6   $��2��6'   $
��Left=�6K   $��Stretch=�6g      AutoGenerateColumns .    CanUserReorderColumns .     CanUserSortColumns .  $	�� 10q�5u      $
��Auto=�5v   +   $
��Auto=�6]   $	��700��5w   +   $
��Auto��68      SelectionMode$ Single=�6E   $y�Hidden=�6\      Columns 5x      5�      5�      5�      5�      