   M S B A M L   `   `   `  ����B  >Cvecara, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CvecaraCvecara  5   	       Cvecara.DodajProizvod   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Cvecara     5   	     � Title$  DodajProizvod��5   	   $	��600��6   $	��600��6,   .��5	      � .+�5
   
   � $
��Left=�6   $	��200��6*   $��	10,10,0,0q�67   $	��Top=�6J   $	��574��6b   .+�5      �� $��Naziv proizvoda:��6   $
��Left=�6/   $��	29,23,0,0q�6J   $	��Top=�6]   $	��111��6u   �� 5      -   5         ��Name$ txtNaziv��5      $
��Left=�6(   $��23��6C   $��	29,54,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6   $	��111��6�   �� 5      $��Cena u dinarima:��6   $
��Left=�6/   $��	29,82,0,0q�6J   $	��Top=�6]   $	��111��6u   $��26��6�   �� 5      -   5        $ txtCena��5      $
��Left=�6'   $��23��6B   $��
29,113,0,0q�6N   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��111��6�   �� 5      -   5        $��Dodaj proizvod��5      $
��Left=�6.   $��396,113,0,0q�6I   $	��Top=�6^   $	��121��6v   $��29��6�   6�   �� 5      $��Vrsta��6   $
��Left=�6$   $��
29,136,0,0q�6?   $	��Top=�6S   $	��111��6k   �� 5      -   5        $ txtVrsta��5      $
��Left=�6)   $��23��6D   $��
29,167,0,0q�6P   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��111��6�   �� 5      -   5        $��Obrisi��5      $
��Left=�6&   $��
396,80,0,0q�6A   $	��Top=�6U   $	��121��6m   $��29��6y   6�   �� 5      -   5        $��Izmeni��5      $
��Left=�6&   $��
396,48,0,0q�6A   $	��Top=�6U   $	��121��6m   $��29��6y   6�   �� 5      -   5        $ 
txtidCveca��5      $y�Visible=�6*   $
��Left=�6?   $��23��6Z   $��
241,23,0,0q�6f   $
 Wrap=�6z   $��idCveca��6�   $	��Top=�6�   $	��120��6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ CveceDataGrid��5   %      
IsReadOnly .    AutoGenerateColumns .  $��	0,234,0,0q�6X      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Naziv��6?      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6N   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *naziv+6N     5      $
 Cena��6>   $ * 6L   	 6%   �� *cena+6L     5      $ Vrsta��6?   $ * 6N   	 6%   �� *vrsta+6N   5      5      5      