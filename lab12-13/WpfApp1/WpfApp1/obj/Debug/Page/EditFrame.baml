   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.EditFrame   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  	EditFrame��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��CustomerGrid��5   `      CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ ID��67      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6C   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5   %   �� 
 �� Path$
 
CustomerId�6K     5       . $
 Name��68   $ 80 6G   	 5   %   �� $

 Name�6E     5       . $ Email��69   $	 120 6H   	 5   %   �� $
 Email�6F     5       . $	 Age��68   $ 60 6F   	 5   %   �� $	
 Age�6D   5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6#   .+�5      �� $	��5 3q�6   $ 
Horizontal=�6&   .+�5       �� $
��Name��6   $��43��6)   $��26��64   �� 5!      -   5         ��Name$
 Name��5!      $��20��6)    �� TextWrapping$
 Wrap=�65   $	��121��6J   5"      �� 5#      $	��5 3q�6   $ 
Horizontal=�6&   .+�5$      �� $	��Age��6   $��38��6'   $��26��62   �� 5%      -   5        $	 Age��5%      $��20��6(   $
 Wrap=�64   $	��121��6I   5&      �� 5'      $��Center=�6   $	��5 3q�64   $ 
Horizontal=�6A   .+�5(      �� $��Email��6   $��49��6*   $��26��65   $��	0,0,0,0.6q�6A   �� 5)      -   5        $ Email��5)      $��20��6)   $
 Wrap=�66   $	��129��6L   $��
0,0,0,-0.4q�6X   5*      �� 5+      -   5         ��Name$ EditCustomer��5+   R   $
��Left=�6   $��10,0,0,0q�61   $
��Edit��6C   $��80��6�   5-        5.   
   -   5        $��	OrderGrid��5.   p    .   .   .  $��2��6a    5/        50       . $ ID��67   $
 auto 6C   	 51   %   �� $
 OrderId�6H     52       . $ Product��69   $ 80 6K   	 53   %   �� $
 ProductName�6L     54       . $ Description��69   $	 120 6N   	 55   %   �� $
 Description�6L     56       . $ Quantity��68   $	 100 6K   	 57   %   �� $
 Quantity�6I     58       . $ Purchase Date��68   $
 auto 6P   	 59   %   �� $
 PurchaseDate� �� StringFormat$ {0:dd.MM.yyyy }��6m     5:       . $ Customer��67   $	 100 6J   	 5;   %   �� $
 Customer.Name�6N   5>      �� 5?   
   $��3��6   .+�5@   
   �� $ 
Horizontal=�6   .+�5A      �� $	��5 3q�6   $ 
Horizontal=�6&   .+�5B      �� $��Product��6   $��94��6,   $��26��67   �� 5C      -   5        $ Product��5C      $��20��60   $
 Wrap=�6<   $	��119��6Q   5D      �� 5E      $	��5 3q�6   $ 
Horizontal=�6&   .+�5F      �� $��Description��6   $��83��63   $��26��6>   �� 5G      -   5        $ Description��5G      $��20��64   $
 Wrap=�6@   $	��126��6U   5H      5J      �� 5K      $ 
Horizontal=�6   .+�5L      �� $	��5 3q�6   $ 
Horizontal=�6*   .+�5M      �� $��PurchaseDate��6   $��94��65   $��26��6@   (  "System.Windows.Controls.DatePicker  5N      -	   5        $��PurchaseDate��5N   !   $��28��65   $	��121��6C   5O      �� 5P      $��Center=�6   $	��5 3q�68   $ 
Horizontal=�6E   .+�5Q      �� $��Quantity��6   $��83��61   $��26��6<   $��	0,0,0,0.6q�6H   �� 5R      -
   5        $ Quantity��5R      $��20��60   $
 Wrap=�6=   $	��126��6S   $��
0,0,0,-0.4q�6_   5S      �� 5T      -   5        $ 	EditOrder��5T   V   $
��Left=�6   $��10,0,0,0q�65   $
��Edit��6G   $��80��6�   5V      5W      5X      5Y      