   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.FIndFrame   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  	FIndFrame��5	      .��5      � 
�������.+�5   
   �� $
��Left=�6   $	��Top=�6.   $
��Name��6G   $��60��6V   $��30��6a    J� RenderTransformOrigin$ 	1.86,1.79&�6m   $��	60,35,0,0q�6�   �� 5   
   -   5         ��Name$
 Name��5   G   $
��Left=�6   $	��Top=�6.   $	��120��6U   $��30��6a   $��
161,35,0,0q�6m   �� 5   
   $
��Left=�6   $	��Top=�6.   $	��Age��6G   $��60��6U   $��30��6`   $��	60,70,0,0q�6l   �� 5   
   -   5        $	 Age��5   G   $
��Left=�6   $	��Top=�6.   $	��120��6T   $��30��6`   $��
161,70,0,0q�6l   �� 5   
   -   5        $
��Find��5   R   $	��100��6   $
��Left=�6   $	��Top=�69   $
��Find��6q   $��30��6�   $��142,124,0,0q�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��CustomerGrid��5   �   $
��Left=�6   $	��Top=�6.      CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .  $��
64,192,0,0q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ ID��67   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 6C   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5   %   ��  �� Path$ 
CustomerId�6K     5       . $
 Name��67   $	 80 6F   
 5   %   �� $
 Name�6E     5       . $ Email��67   $		 120 6F   
 5   %   �� $ Email�6F     5       . $	 Age��67   $	 60 6E   
 5   %   �� $	 Age�6D   5      5      5      