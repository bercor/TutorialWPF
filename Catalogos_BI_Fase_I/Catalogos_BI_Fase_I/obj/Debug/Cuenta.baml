   M S B A M L   `   `   `  ����N  JCatalogos_BI_Fase_I, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Catalogos_BI_Fase_I.ObjetosBDCatalogos_BI_Fase_I.ObjetosBD  5   	        Catalogos_BI_Fase_I.Cuenta   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <self+clr-namespace:Catalogos_BI_Fase_I.ObjetosBD     5   	   -   5          � Title$  Cuenta��5   	   $	��400��6   $	��400��6%   .��5      �  � RowDefinitions 5   
   �� 5	      $��1* �6   �� 5
      $��30 �6   .+�5   
   R� -   5        $��
trvCuentas��5   i    � DataContext 6   ��  �� ElementName$ UI�� �� Path$ Cuentas���6H   �� *
Children+ � 	Resources 5       �� DataType+   %Catalogos_BI_Fase_I.ObjetosBD.Cuentas �� ItemsSource �� Orientation��%�   (��       5   +   *, +)�� 6   "  6+    6L   �� *
Children+.R�5      �� $ 
Horizontal=�6!   .+�5      �� ��6$   �� *
IdCuenta+�� 5      $	��   ��6$   �� 5      ��6$   �� *NombreCuenta+5      5      5      ��5      �� 5      	 �� 
TargetType"	 Q�6   .�5      �� 
 �� Property
 �@Q�
IsSelected �� Value 63   �� *
IsSelected+�� 5      
 �@Q�
IsExpanded 63   �� *
IsExpanded+5      5      �� 5   
   $��1��6   $ 
Horizontal=�6"   $��Right=�6;   .+�5      �� -   5        $��Seleccionar��5      $��20,5,5,5q�6B   $	��100��6T   .��6`   _Seleccionar5       �� 5!      -   5        $��
btnLimpiar��5!      $��20,5,5,5q�6)   $	��100��6;   .��6a   
_Limpiar5#      �� 5$      -   5        $��	btnCerrar��5$      $��	20,5,20,5q�6'   $	��100��6:   .��6^   	_Cerrar5&      5'      5(      5)      