   M S B A M L   `   `   `  ����>  :ADO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ADOADO  5          ADO.AddFrame   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:ADO     5        N� Title$  AddFrame��5	      .��5      � 
�������.+�5   
   �� .+�5      	� -   5        $��
Discipline��5   E    d� 	IsChecked$
 TrueY�6   $��25 15q�6X   $��Center=�6h   ��5      �� 5      $��14(�6    $��
Discipline��6.   5      �� 5      -   5         ��Name$ DisciplinePanel1��5       �� Orientation$ 
Horizontal=�63   .+�5      �� $
��25 5q�6   .+�5      �� $��14(�6    $��Discipline Name��6.   �� 5      -   5         ��Name$ DisciplineName��5      $��23��66   $��0 5 0 0q�6B   $	��150��6S    �� TextWrapping$
 Wrap=�6_   5      �� 5      $
��25 5q�6   .+�5      �� $��14(�6    $
��Term��6.   �� 5      -   5        $
��Term��5      $��0 5 0 0q�6+   $	��120��6<   .@�5      �� $��1��6'   �� 5      $��2��6'   5      5      �� 5      $
��45 5q�6   .+�5      �� $��14(�6    $��Cource��6.   �� 5       -   5        $��Course��5       $��0 5 0 0q�6-   $	��120��6>   .@�5!      �� $��1��6'   �� 5"      $��2��6'   �� 5#      $��3��6'   �� 5$      $��4��6'   5%      5&      �� 5'      $
��25 5q�6   .+�5(      �� $��14(�6    $��Specialization��6.   �� 5)      -   5         ��Name$ Specialization��5)   1   $��0 5 0 0q�6    $	��120��6I   .@�5*      �� $
��POIT��6'   �� 5+      $��POIBMS��6'   �� 5,      $
��ISIT��6'   �� 5-      $
��DEVI��6'   5.      5/      50      �� 52      -   5        $��DisciplinePanel2��52      $ 
Horizontal=�61   .+�53      �� $
��25 8q�6   .+�54      �� $ 
Horizontal=�6!   .+�55      �� $��14(�6$   $��Count of lectures��62   �� 56      $
��15 0q�6$   $��14(�62   ��6@   ��  �� ElementName$ LecturesCount�� �� Path$ Value�57      �� 58      -   5        	 ��Name$	 LecturesCount��59   8   
 �� TickPlacement$
 BottomRight=�58       �� TickFrequency$ 1Q�69    �� IsSnapToTickEnabled . $��0 15 0 0q�59   P    � Value$ 0Q�6b    � Minimum$ 0Q�6l    � Maximum$ 40Q�6x   $	��150��6�   5:      �� 5;      $
��25 8q�6   .+�5<      �� $ 
Horizontal=�6!   .+�5=      �� $��14(�6$   $��Count of labs��62   �� 5>      $
��15 0q�6$   $��14(�62   ��6@   �� $ 	LabsCount��$ Value�5?      �� 5@      -	   5        $	 	LabsCount��5@   t   $
 BottomRight=�6   $ 1Q�69   $ 40Q�6K    . $��0 15 0 0q�6�   $	��150��6�   5A      �� 5B      $
��15 5q�6   .+�5C      �� $��14(�6    $��Control Type��6.   �� 5D      -
   5        $��ControlType��5D      $��0 12 0 0q�62   $	��120��6D   .@�5E      �� $��
Зачет��6'   �� 5F      $��Экзамен��6'   5G      5H      5I      	� 5J      -   5        $��Lector��5J   4   $��25 15q�6B   $��Center=�6R   ��5K      �� 5L      $��14(�6    $��Lector��6.   5N      �� 5O      -   5        $��LectorPanel1��5O   0   $y�	Collapsed=�6   $ 
Horizontal=�6D   .+�5P      �� $
��25 5q�6   .+�5Q      �� $��14(�6    $	��SNP��6.   �� 5R      -   5        $	��SNP��5R      $��23��6)   $��0 5 0 0q�65   $	��150��6F   $
 Wrap=�6R   5S      �� 5T      $
��25 5q�6   .+�5U      �� $��14(�6    $��Pulpit��6.   �� 5V      -   5        $ Pulpit��5V      $��23��6.   $��0 5 0 0q�6:   $	��150��6K   $
 Wrap=�6W   5W      5Y      �� 5Z      -   5        $��LectorPanel2��5Z   0   $y�	Collapsed=�6   $��Stretch=�6D   $ 
Horizontal=�6b   .+�5[      �� $
��25 5q�6   .+�5\      �� $��14(�6    $��Auditory��6.   �� 5]      -   5        $ Auditory��5]      $��23��60   $��0 5 0 0q�6<   $	��150��6M   $
 Wrap=�6Y   5^      �� 5_      $
��25 5q�6   .+�5`      �� $ 
Horizontal=�6!   .+�5a      �� $��14(�6$   $��Photo��62   �� 5b      -   5        $��40��5b   3   $
��15 0q�6>   $��Select��6L   5c      �� 5d      -   5         ��Name$ Photo��5d       J� 	AllowDrop . $	��100��6<   $	��100��6H   5e      5f      �� 5g      -   5        $	��Add��5g   -   $	��0 0q�6;   $��30��6H   $	��Top=�6T   $	��120��6l   5i      5j      5k      