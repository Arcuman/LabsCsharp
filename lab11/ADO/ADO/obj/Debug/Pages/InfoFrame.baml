   M S B A M L   `   `   `  ����>  :ADO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ADOADO  5          ADO.InfoFrame   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:ADO     5        N� Title$
  Info��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��
Discipline��6   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DB_Discipline��5      $��1��6,      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   ��  �� Path$
 Name�  5      $ Семестр��6%    66   �� $
 Term�  5      $ Курс��6%    63   �� $ Cource�  5      $  Специализация��6%    6<   �� $ Specialization�  5      $ Кол-во лекций��6%    6<   �� $ LecturesCount�  5      $ Кол-во лаб��6%    69   �� $ 	LabsCount�  5      $ Вид контроля��6%    6;   �� $ ControlType�5      �� 5    
   $	��0 2q�6   $��2��6"    �� Orientation$ 
Horizontal=�6/   .+�5!      �� -   5        $
��Left=�5!   8   $��30��6S   $��50��6_   $
��10 0q�6j   $��
Назад��6y   �� 5"      -   5        $
��Left=�5"   2   $��30��6M   $��50��6Y   $	��5 0q�6d   $��Вперед��6r   �� 5#      -   5        $
��Left=�5#   .   $��30��6I   $��60��6U   $	��5 0q�6`   $��Изменить��6n   5$      �� 5%   
   $��3��6   $��Lectors��6!     5&   
   -   5        $ 	DB_Lector��5&      $��4��6&    .   5'        5(      $ Фамилия��6%    66   �� $	 SNP�  5)      $ Аудитория��6%    68   �� $ Auditory�  5*      $ Кафедра��6%    66   �� $ Pulpit�  5+      $ Изображение��6%    6:   �� $ 	ImageData�5-      �� 5.   
   $	��0 2q�6   $��5��6"   $ 
Horizontal=�6/   .+�5/      �� -   5        $
��Left=�5/   5   $��30��6P   $��50��6\   $
��10 0q�6g   $��
Назад��6v   �� 50      -   5        $
��Left=�50   4   $��30��6O   $��50��6[   $	��5 0q�6f   $��Вперед��6t   51      52      53      