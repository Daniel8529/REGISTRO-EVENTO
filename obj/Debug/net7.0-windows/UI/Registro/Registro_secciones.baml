   M S B A M L   `   `   `  ����P  LRegistro_venta_boleta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Registro_venta_boleta.UI.Registro!Registro_venta_boleta.UI.Registro  5   	   :    4Registro_venta_boleta.UI.Registro.Registro_secciones   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Alocal/clr-namespace:Registro_venta_boleta.UI.Registro     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   .��5
      ��   �� CornerRadius$  0��6   ���#eeeeee._�5   
   � $	��NaN��6   $��	0,0,0,-82q�6   .+�5      �� $��Eventos��6   $
��Left=�5      $��	67,42,0,0q�5      $	��Top=�5      $��86��5      $��30��5      $��Times New Roman)�5      $��20(�5      $
��Bold"�5      �� 5      -   5         ��Name$ ComboBoxEvento��5      $
��Left=�5      $	��Top=�5       $	��224��5!      $��30��5"      $��
161,41,0,0q�5#      �� 5&      $
��Tipo��6   $
��Left=�5'      $��
67,101,0,0q�5(      $	��Top=�5)      $��86��5*      $��30��5+      $��Times New Roman)�5,      $��20(�5-      $
��Bold"�5.      �� 50      -   5        $ ComboBoxTipo��50      $
��Left=�52      $	��Top=�53      $	��224��54      $��30��55      $��161,101,0,0q�56      �� 59      $��Cantidad��6   $
��Left=�5:      $��
67,150,0,0q�5;      $	��Top=�5<      $��94��5=      $��30��5>      $��Times New Roman)�5?      $��20(�5@      $
��Bold"�5A      �� 5D      -   5         ��Name$ TexBoxcantidad��5D      $
��Left=�5E      $��161,150,0,0q�5F       �� TextWrapping$
 Wrap=�5G      $	��Top=�5H      $	��224��5I      $��30��5J      $��20(�5K      $��Times New Roman)�5L      .��5M      ��5O      �� 5Q       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5S      �  � Color$ Black��6'   � 5U      $ Black��6'    � Offset$ 1Q�65   5W      .��5Y   '   5[      �� 5\      $��421,6,189,468q�6   $	��NaN��6,   $	��NaN��69   &   System.Windows.Controls.DataGrid  5^      -   5          Name$ TablaDetalle��5^      $��30,225,30,160q�5_      	   
IsReadOnly$
	 true��5a      
   Columns
 5e      4  .System.Windows.Controls.DataGridTemplateColumn  5g         CellTemplate 5i      �� 5k      .R�5m   "   ��  ��Name$ VerDatos��6*   -   5        $��eliminar��5n   2   
�������5p   2   5r      5v      5z      �� 5|      -   5        $
��Left=�5}      ���#3385ff$��715,165,0,0q�5      $	��Top=�5�      $	��120��5�      $��31��5�      .��5�      ]� .+�5�      �� $��0,0,10,0q�6   $��/Imagen/Nuevo.png��6/   �� 5�      $��0,0,5,0q�6!   
�������$��Agregar��6F   5�      5�      �� 5�      -   5        $
��Left=�5�      ���#3385ff$��139,527,0,0q�5�      $	��Top=�5�      $	��120��5�      $��31��5�      .��5�      ]� .+�5�      �� $��0,0,10,0q�6   $��/Imagen/Nuevo.png��6/   �� 5�      $��0,0,5,0q�6!   
�������$��Nuevo��6F   5�      5�      �� 5�      -   5        $
��Left=�5�      ���#47d147$��306,527,0,0q�5�      $	��Top=�5�      $	��130��5�      $��31��5�      .��5�      ]� .+�5�      �� $��0,0,10,0q�6   $��/Imagen/Guardar.png��6/   �� 5�      $��0,0,5,0q�6!   
�������$��Guardar��6E   5�      5�      �� 5�      -	   5        $
��Left=�5�      ���#ff3333$��486,527,0,0q�5�      $	��Top=�5�      $	��130��5�      $��31��5�      .��5�      ]� .+�5�      �� $��0,0,10,0q�6   $��/Imagen/Eliminar.png��6/   �� 5�      $��0,0,5,0q�6!   
�������$��Eliminar��6F   5�      5�      5�      5�      5�      