   M S B A M L   `   `   `  ���� B  >Cvecara, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CvecaraCvecara      Cvecara.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Cvecara       � Title$  Cvecara 'M'��$��690.498��$��672.651��.���  � ColumnDefinitions �� $	��10* ��� $	��19* �.+��� -   $��Cancel��$
��Left=�$��303.4,583,0,0q�$	��Top=�$	��112��$��32��$��1���� $G��AC:\Users\Win7\Downloads\cvecara\cvecara\Cvecara\cvetna-pijaca.png��$��0,10,349.4,479.8q� J� RenderTransformOrigin$ 	1.27,0.62&�$��Right=�$	��306��$��2��(  "System.Windows.Controls.DatePicker  -     Name$ picker��$
��Left=�$��
63,532,0,0q�$	��Top=�$��29��$	��149���� -   $
��Kupi��$
��Left=�$��
63,583,0,0q�$	��Top=�$	��149��$��25���� -   $�� Dodaj proizvod��$
��Left=�$��303.4,39,0,0q�$	��Top=�$	��112��$��32��$��1���� -   $��Lokacija��$
��Left=�$��136.4,39,0,0q�$	��Top=�$	��112��$��32��$ 2.265,-3.602&�$��1��&   System.Windows.Controls.DataGrid  -     Name$ CveceDataGrid��   
IsReadOnly .    AutoGenerateColumns .  $��0,184,0,311q�$��2��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Naziv��	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *naziv+  $
 Cena��$	 * 
 �� *cena+  $ Vrsta��$	 * 
 �� *vrsta+�� -    ��Name$ 
txtidCveca��$y�Hidden=�$
��Left=�$��23��$��
10,378,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��120���� $��Naziv��$
��Left=�$��202,378,0,0q�$	��Top=�$	��114��$��23��$��2���� -   $ txtNaziv��$
��Left=�$��23��$��202,406,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��120��$��2���� $
��Cena��$
��Left=�$��202,434,0,0q�$	��Top=�$��26��$	��114��$��2���� -	   $ txtCena��$
��Left=�$��23��$��202,465,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��120��$��2���� $��Vrsta��$
��Left=�$��159.4,383,0,0q�$	��Top=�$��23��$��89��$��1���� -
   $ txtVrsta��$
��Left=�$��22��$
 Wrap=�$�� ��$	��Top=�$	��121��$��159.4,434,0,0q�$��1��