   M S B A M L   `   `   `  ���� B  >Cvecara, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CvecaraCvecara      Cvecara.Lokacija   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Cvecara       � Title$  Lokacija��$��548.616��$	��600��.��� .+�� $
��Left=�$	��200��$��
18,308,0,0q�$	��Top=�$	��574��.+��� $��Grad:��$
��Left=�$��	29,23,0,0q�$	��Top=�$	��111���� -    ��Name$ txtGrad��$
��Left=�$��23��$��	29,54,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��111���� $��Telefon��$
��Left=�$��	29,82,0,0q�$	��Top=�$	��111��$��26���� -   $ 
txtTelefon��$
��Left=�$��23��$��
29,113,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��111���� -   $��Dodaj��$
��Left=�$��396,113,0,0q�$	��Top=�$	��121��$��29���� $��Adresa��$
��Left=�$��
29,136,0,0q�$	��Top=�$	��111���� -   $ 	txtAdresa��$
��Left=�$��23��$��
29,167,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��111���� -   $��Obrisi��$
��Left=�$��
396,80,0,0q�$	��Top=�$	��121��$��29���� -   $��Izmeni��$
��Left=�$��
396,48,0,0q�$	��Top=�$	��121��$��29���� -   $ txtidLokacije��$y�Hidden=�$
��Left=�$��23��$��
241,23,0,0q�$
 Wrap=�$��
idLokacije��$	��Top=�$	��120��&   System.Windows.Controls.DataGrid  -     Name$ LokacijaDataGrid��   
IsReadOnly .    AutoGenerateColumns .  $
��Left=�$	��298��$��	10,10,0,0q�$	��Top=�$	��574��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Grad��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� *grad+  $ Telefon��$ * 	 �� *	telefon+  $ Adresa��$ * 	 �� *adresa+