   M S B A M L   `   `   `  ���� B  >Cvecara, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CvecaraCvecara      Cvecara.DodajProizvod   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Cvecara       � Title$  DodajProizvod��$	��600��$	��600��.��� .+�� $
��Left=�$	��200��$��	10,10,0,0q�$	��Top=�$	��574��.+��� $��Naziv proizvoda:��$
��Left=�$��	29,23,0,0q�$	��Top=�$	��111���� -    ��Name$ txtNaziv��$
��Left=�$��23��$��	29,54,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��111���� $��Cena u dinarima:��$
��Left=�$��	29,82,0,0q�$	��Top=�$	��111��$��26���� -   $ txtCena��$
��Left=�$��23��$��
29,113,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��111���� -   $��Dodaj proizvod��$
��Left=�$��396,113,0,0q�$	��Top=�$	��121��$��29���� $��Vrsta��$
��Left=�$��
29,136,0,0q�$	��Top=�$	��111���� -   $ txtVrsta��$
��Left=�$��23��$��
29,167,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��111���� -   $��Obrisi��$
��Left=�$��
396,80,0,0q�$	��Top=�$	��121��$��29���� -   $��Izmeni��$
��Left=�$��
396,48,0,0q�$	��Top=�$	��121��$��29���� -   $ 
txtidCveca��$y�Hidden=�$
��Left=�$��23��$��
241,23,0,0q�$
 Wrap=�$��idCveca��$	��Top=�$	��120��&   System.Windows.Controls.DataGrid  -     Name$ CveceDataGrid��   
IsReadOnly .    AutoGenerateColumns .  $��	0,234,0,0q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Naziv��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� *naziv+  $
 Cena��$ * 	 �� *cena+  $ Vrsta��$ * 	 �� *vrsta+