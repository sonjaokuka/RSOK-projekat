   M S B A M L   `   `   `  ����B  >Cvecara, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CvecaraCvecara  5   	       Cvecara.Lokacija   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Cvecara     5   	     � Title$  Lokacija��5   	   $��548.616��6   $	��600��6+   .��5	      � .+�5
   
   � $
��Left=�6   $	��200��6*   $��
18,308,0,0q�67   $	��Top=�6K   $	��574��6c   .+�5      �� $��Grad:��6   $
��Left=�6$   $��	29,23,0,0q�6?   $	��Top=�6R   $	��111��6j   �� 5      -   5         ��Name$ txtGrad��5      $
��Left=�6'   $��23��6B   $��	29,54,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $�� ��6u   $	��Top=�6~   $	��111��6�   �� 5      $��Telefon��6   $
��Left=�6&   $��	29,82,0,0q�6A   $	��Top=�6T   $	��111��6l   $��26��6x   �� 5      -   5        $ 
txtTelefon��5      $
��Left=�6*   $��23��6E   $��
29,113,0,0q�6Q   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��111��6�   �� 5      -   5        $��Dodaj��5      $
��Left=�6%   $��396,113,0,0q�6@   $	��Top=�6U   $	��121��6m   $��29��6y   6�   �� 5      $��Adresa��6   $
��Left=�6%   $��
29,136,0,0q�6@   $	��Top=�6T   $	��111��6l   �� 5      -   5        $ 	txtAdresa��5      $
��Left=�6*   $��23��6E   $��
29,167,0,0q�6Q   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��111��6�   �� 5      -   5        $��Obrisi��5      $
��Left=�6&   $��
396,80,0,0q�6A   $	��Top=�6U   $	��121��6m   $��29��6y   6�   �� 5      -   5        $��Izmeni��5      $
��Left=�6&   $��
396,48,0,0q�6A   $	��Top=�6U   $	��121��6m   $��29��6y   6�   �� 5      -   5        $ txtidLokacije��5      $y�Visible=�6-   $
��Left=�6B   $��23��6]   $��
241,23,0,0q�6i   $
 Wrap=�6}   $��
idLokacije��6�   $	��Top=�6�   $	��120��6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ LokacijaDataGrid��5   B      
IsReadOnly .    AutoGenerateColumns .  $
��Left=�6\   $	��298��6w   $��	10,10,0,0q�6�   $	��Top=�6�   $	��574��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Grad��6>      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6L   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *grad+6L     5      $ Telefon��6A   $ * 6R   	 6%   �� *	telefon+6R     5      $ Adresa��6@   $ * 6P   	 6%   �� *adresa+6P   5      5      5      