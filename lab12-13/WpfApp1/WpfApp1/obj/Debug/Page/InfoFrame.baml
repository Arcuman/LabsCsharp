   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.InfoFrame   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  	InfoFrame��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��CustomerGrid��5   `      CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ ID��67      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6C   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5   %   �� 
 �� Path$
 
CustomerId�6K     5       . $
 Name��67   $ 80 6F   	 5   %   �� $

 Name�6E     5       . $ Email��67   $	 120 6F   	 5   %   �� $
 Email�6F     5       . $	 Age��67   $ 60 6E   	 5   %   �� $	
 Age�6D   5        5   
   -   5        $��	OrderGrid��5   p    .   .   .  $��1��6a    5        5       . $ ID��67   $
 auto 6C   	 5   %   �� $
 OrderId�6H     5        . $ Product��67   $ 80 6I   	 5!   %   �� $
 ProductName�6L     5"       . $ Description��67   $	 120 6L   	 5#   %   �� $
 Description�6L     5$       . $ Quantity��67   $	 100 6J   	 5%   %   �� $
 Quantity�6I     5&       . $ Purchase Date��67   $
 auto 6O   	 5'   %   �� $
 PurchaseDate� �� StringFormat$ {0:dd.MM.yyyy }��6m     5(       . $ Customer��67   $	 100 6J   	 5)   %   �� $
 Customer.Name�6N   5,      5-      5.      