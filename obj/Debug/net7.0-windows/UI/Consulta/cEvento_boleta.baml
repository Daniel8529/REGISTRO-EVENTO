   M S B A M L   `   `   `  ����P  LRegistro_venta_boleta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Registro_venta_boleta.UI.Consulta!Registro_venta_boleta.UI.Consulta  5   	   6    0Registro_venta_boleta.UI.Consulta.cEvento_boleta   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Alocal/clr-namespace:Registro_venta_boleta.UI.Consulta     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   
   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   .��5	      ��   �� CornerRadius$  0��6   ���#eeeeee._�5
   
   � .+�5      ��  �� Orientation$ 
Horizontal=�6   $��
30,72,30,0q�5      $	��Top=�5      .+�5      �� $ Vertical=�6   $��Center=�5      $��Center=�5      .+�5      �� $��Id��6$   $	��Top=�5      $��35��5      $��14(�6)   �� 5      -   5         ��Name$ 	IdTextBox��5   &    �� TextWrapping$
 Wrap=�5      $��55��5         SecondaryHueMidBrush.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush# �   5      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ SecondaryDark=�5       5#      �� 5&      $ Vertical=�6   $��10, 0q�5'      $��Center=�5(      $��Center=�5)      .+�5,      �� $��Nombre��6   $��35��5-      $��14(�5.      �� 51      -   5        $ NombreTextBox��51      $
 Wrap=�52      $	��223��53      # �   54      $ SecondaryDark=�55      56      5;      �� 5=      $ 
Horizontal=�6   $	��Top=�5>      $��30,137,30,0q�5?      .+�5C      �� $ Vertical=�6   $��Center=�5D      $��Center=�5E      .+�5H      �� $��Desde��6    $��35��5I       $��14(�5J       (  "System.Windows.Controls.DatePicker  5M      -   5          Name$ 	DesdeDate��5M   %   $	��127��5N   %   ���#eeeeee# �   5P   %   $ SecondaryDark=�5Q   %   5S      �� 5V      $ Vertical=�6   $��10, 0q�5W      $��Center=�5X      $��Center=�5Y      .+�5\      �� $��Hasta��6    $��35��5]       $��14(�5^         5a      -   5        $ 	HastaDate��5a   %   
���   �$	��125��5c   %   # �   5d   %   $ SecondaryDark=�5e   &   5g      �� 5j      $ Vertical=�6   $��10, 0q�5k      $��Center=�5l      $��Center=�5m      .+�5p      �� $��Tipo de asistencia��6    $	��Top=�5q       $��35��5r       $��14(�5s       $y�	Collapsed=�5t       �� 5w      -   5        $ TipoTextBox��5w   "   $
 Wrap=�5x   "   $	��163��5y   "   # �   5z   "   $ SecondaryDark=�5{   "   $y�	Collapsed=�5|   "   5~      �� 5�      $ Vertical=�6   $��10, 0q�5�      $��Center=�5�      $��Center=�5�      .+�5�      �� $
��Area��6    $��35��5�      $��14(�6%   $y�	Collapsed=�5�      �� 5�      -   5        $ AreaTextBox��5�   "   $
 Wrap=�5�      $	��162��5�      # �   6%   $ SecondaryDark=�5�      $y�	Collapsed=�5�      5�      �� 5�      -   5         ��Name$ Buscar��5�      $��Buscar��5�      
�������$
��2, 0q�5�       " MaterialDesignRaisedDarkButton#��[ 5�      $	��125��5�      $��35��5�      $��Bottom=�5�      $��Center=�5�      �� 5�      -   5        $ Nuevo��5�      $��Nuevo��5�      
�������$
��2, 0q�5�      #��[ 5�      $	��125��5�      $��35��5�      $��Bottom=�5�      $��Center=�5�      $
��Left=�5�      5�      �� 5�      -	   5         ��Name$ 
imagImagen��5�      $��550,0,-100,420q�6.   $	��500��6G   $	��295��6T   &   System.Windows.Controls.DataGrid  5�      -
   5        	  Name$	 
TablaTexto��5�      $��30,217,30,61q�5�      
   
IsReadOnly$

 true��5�      ��5�      ��  �� Path$ 	Articulos� �� SelectedItem 5�      �� $ SelectedArticulos� �� Mode$ TwoWay=�   Columns 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�         CellTemplate 5�      �� 5�      .R�5�   "   �� $ VerDatos��6)   -   5        $��Editar��5�   )   
�������5�   )   5�      5�        5�       5�      �� 5�      .R�5�   "   �� $ VerEliminar��6)   -   5        $��Eliminar��5�   )   
�������5�   )   5�      5�      5�      5�      5�      5�      