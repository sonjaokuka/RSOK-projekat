   M S B A M L   `   `   `  ����B  >Cvecara, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CvecaraCvecara  5   	       Cvecara.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Cvecara     5   	     � Title$  Cvecara 'M'��5   	   $��690.498��6   $��672.651��6.   .��5	      � .+�5
   
   �� $��Cancel��6   $
��Left=�6"   $��533,583,0,0q�6=   $	��Top=�6R   $	��112��6j   $��32��6v   �� 5   
   $s��mC:\Users\Dusan\Desktop\Miljana\Druga godina\Projektovanje softvera\Vezbe\Seminarski-Cvecara\cvetna-pijaca.png��6   $��0,10,349,480q�6�    J� RenderTransformOrigin$ 	1.27,0.62&�6�   $��Right=�6�   $	��306��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ picker��5      $
��Left=�6%   $��
63,532,0,0q�6@   $	��Top=�6T   $��29��6l   $	��149��6x   �� 5   
   -   5        $
��Kupi��5      $
��Left=�6    $��
63,583,0,0q�6;   $	��Top=�6O   $	��149��6g   $��25��6s   6   �� 5   
   -   5        $�� Dodaj proizvod��5      $
��Left=�6,   $��
533,39,0,0q�6G   $	��Top=�6[   $	��112��6s   $��32��6   6�   �� 5   
   -   5        $��Lokacija��5      $
��Left=�6$   $��
366,39,0,0q�6?   $	��Top=�6S   $	��112��6k   $��32��6w   $ 2.265,-3.602&�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ CveceDataGrid��5   %      
IsReadOnly .    AutoGenerateColumns .  $��-10,184,10,311q�6X      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Naziv��6?      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6N   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *naziv+6N     5      $
 Cena��6>   $ * 6L   	 6%   �� *cena+6L     5      $ Vrsta��6?   $ * 6N   	 6%   �� *vrsta+6N   5      �� 5   
   -   5        
 ��Name$
 
txtidCveca��5      $
��Left=�6&   $��23��6A   $��
10,378,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5   
   $��Naziv��6   $
��Left=�6    $��202,378,0,0q�6;   $	��Top=�6P   $	��114��6h   $��23��6t   �� 5   
   -   5        $
 txtNaziv��5      $
��Left=�6$   $��23��6?   $��202,406,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   $
��Cena��6   $
��Left=�6   $��202,434,0,0q�6:   $	��Top=�6O   $��26��6g   $	��114��6s   �� 5   
   -   5        $
 txtCena��5      $
��Left=�6#   $��23��6>   $��202,465,0,0q�6J   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   �� 5   
   $��Vrsta��6   $
��Left=�6    $��389,383,0,0q�6;   $	��Top=�6P   $��23��6h   $��89��6t   �� 5   
   -	   5        $
 txtVrsta��5      $
��Left=�6$   $��22��6?   $
 Wrap=�6K   $�� ��6_   $	��Top=�6g   $	��121��6   $��389,434,0,0q�6�   5&      5'      