   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel  5   	   D @ToDo_List, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ToDo_List	ToDo_List 5   	   S OWpfCustomControlLibrary1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulleHclr-namespace:WpfCustomControlLibrary1;assembly=WpfCustomControlLibrary1WpfCustomControlLibrary1 5	   	      ToDo_List.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      5   	   @d2http://schemas.microsoft.com/expression/blend/2008      5   	   Hscm8clr-namespace:System.ComponentModel;assembly=WindowsBase      5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006      5   	   )localclr-namespace:ToDo_List      5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ZMyNamespaceHclr-namespace:WpfCustomControlLibrary1;assembly=WpfCustomControlLibrary1  5	   	   O KWPFLocalizeExtension, Version=3.3.1.0, Culture=neutral, PublicKeyToken=null2lex(http://wpflocalizeextension.codeplex.com  5   	   -   5        $��Window1��5   	   $	��500��5
   	   $	��800��6      BackgroundWindow#���   5   	   4  .WPFLocalizeExtension.Engine.LocalizeDictionary    DesignCulture$  en��5   	   =  7WPFLocalizeExtension.Providers.ResxLocalizationProvider   DefaultAssembly$ 	ToDo_List��5   	      DefaultDictionary$ 	Resources��5   	    � Icon$+ %pack://application:,,,/Image/icon.png��5   	   $	��600��5   $   $	��500��61    � Title 6	   2  ,WPFLocalizeExtension.Extensions.LocExtension  *
TitleApp+ � 	Resources 5      +  %ToDo_List.BooleanToVisiblityConverter  BooleanToVisiblityConverter)  #ToDo_List.PriorityToStringConverter  PriorityToStringConverter'  !ToDo_List.StatusToStringConverter  StatusToStringConverter  
borderBase �� 
TargetType �� Property �� Value��%"  &	       &	      &	 &     &	 9     '�� �       5   
   6,     5   
   6*     5   
   6(   �� 5   
   " ��6#   .�5      ��  � ��
 �   �6,   �� 5       � ��$ 1q�60   5      �� 5   
   " ��6   .�5      ��  � ��$
 Left=�6;   5      5       	 J� CommandBindings	 5!      )  #System.Windows.Input.CommandBinding  5"   
   -   5          ToDo_List.MainWindow
   GreetUserCommand   Command# Z
 5"      6r    � ContextMenu 5$      �� 5%   
   .@�5&      m�  m� Command# Z
 6   5'      .��5)      �� $
��Auto=�6   .��5*   
   �  � RowDefinitions 5+      �� 5,      $��2* �6    6.   �� 5-      $
��Auto �6    60   �� 5.      $��* �6    6-   �� 5/      $��* �6    6-   .+�52      �� -   5        $��lstTasks��54       �� SelectedItem 52      �� *SelectedTask+ �� Mode$ TwoWay=�{�53      �� *	IsEnabled+��55      �� *	TasksList+ �� FallbackValue$ 	TasksList�� �� View 57      �� 58      .P�59      ��  �� Width$	 300��6)   ��66     *Title+ �� CellTemplate 5:      �� 5;   "   .R�5<   &   �� ��60   �� *Title+$ 10��5=   #   5?      �� 5@      $	 270��6*   ��66     *
Priority+ �� DisplayMemberBinding 6R   �� *
Priority+$ SD�� �� 	Converter# [ �� 5A      $	 250��6*   ��66     *Status+ 6P   �� *Status+$ SD��# [ 5B      5D      � 5F      $��1��6   .+�5H      �� $��1��6   $
��Left=�6+    �� Orientation$ 
Horizontal=�6F   $��5,2,5,10q�6_   .+�5I      �� $��Center=�6    $��2,0,0,0q�6;   $��Фильтрация по��6L   $��16(�6a   6q   �� 5J      $��2,0,0,0q�6   $��2q�6R   ��6.   �� *PriorityCommand+��6^     *PrioritySort+�� 5K      $��2,0,0,0q�6   $��2q�6P   ��6.   �� *StatusCommand+��6\     *
StatusSort+�� 5L      $��2,0,0,0q�6   $��2q�6R   ��6.   �� *LanguageCommand+��6^     *
Language+5M      �� 5N      $��1��6   $��Right=�6*   $ 
Horizontal=�6F   $��5,2,5,10q�6_   .+�5O      �� $��
2,0,0,-0.4q�6   $��2q�6Q   ��61   �� *SaveCommand+��6]     *Save+�� 5P      $��2,0,0,0q�6   $��2q�6P   ��6.   �� *CancelCommand+��6\     *Cancel+�� 5Q      $��2,0,0,0q�6   $��2q�6N   ��6.   �� *EditCommand+��6Z     *Edit+�� 5R      $��2,0,0,0q�6   $��2q�6M   ��6.   �� *
AddCommand+��6Y     *Add+�� 5S      $��2,0,0,0q�6   $��2q�6P   ��6.   �� *DeleteCommand+��6\     *Delete+5T      5U      �� 5Z      $��2��6    �� Padding$ 7q�6"   $��7q�6.     BackgroundDescription#���  69   ._�5[      �  � DataContext 6   ��  �� ElementName$ lstTasks�� �� Path$ SelectedItem� � ColumnDefinitions 5]      �� 5^      $
��Auto �6+   6:   �� 5_      $��* �6+   67   �� 5`      $
��Auto �6+   6:   �� 5a      $��* �6+   67   �� 5b      $
��Auto �6+   6:   �� 5c      $��* �6+   67    5e      �� 5f       z� SharedSizeGroup$ SomeText��6(   $
��Auto �6C   6S   �� 5g      $ SomeText��6(   $
��Auto �6C   6S   �� 5h      $
��Auto �6(   68   �� 5i      $��* �6(   65   .+�5n      ��   AnimationText#��[ 6    $��7q�6G   ��6R     *Title+�� 5o      $��1��6   $��5q�5p      {�5q      �� *	IsEnabled+$ False��.��5r      ��5s      �� 5t      $ Title�6&   $ TwoWay=�63    �� ValidatesOnExceptions .  �� UpdateSourceTrigger$ PropertyChanged=�6^     �� ValidationRules  5u   "   5	  /System.Windows.Controls.DataErrorValidationRule	  5v   &   5x      .��5y   (   5z      �� 5~      #��[ 6    $��7q�6G   $��1��6R   ��6_     *
Category+�� 5      $��1��6   $��1��6+   $��5q�5�      {�6%   �� *	IsEnabled+$ False��.��5�      ��5�      �� 5�      $ Category�6&   $ TwoWay=�66    . $ PropertyChanged=�6a     5�   "   	  5�   &   5�      .��5�   (   5�      �� 5�      #��[ 6    $��7q�6G   $��2��6R   ��6b     *	StartDate+(
  "System.Windows.Controls.DatePicker
  5�      $��3q�5�      $��3��5�      y�5�   "   �� *	IsEnabled+# [ ! �� ConverterParameter$
! True��$ Hidden��{�5�   &   �� *	IsEnabled+$ False��" 
  Text" 5�      �� 5�      $ 	StartDate�6&   $ TwoWay=�67    . $ PropertyChanged=�6b     5�   "   	  5�   &   5�      5�      �� 5�      $��5q�5�      $��3��5�      y�5�      �� *	IsEnabled+# [ {�5�   &   �� *	IsEnabled+$ False����5�      �� *	StartDate+$ TwoWay=�$ PropertyChanged=��� 5�      #��[ 6    $��7q�6G   $��1��6R   $��2��6_   ��6o     *
Priority+�� 5�      $��5q�5�      $��1��5�      $��3��6)   y�5�      �� *	IsEnabled+# [ {�5�      �� *	IsEnabled+$ False����5�      �� *
Priority+$ TwoWay=�$ PropertyChanged=�# [ �� 5�      $��1��5�      $��3��6"   $
��20px��5�      # �� DisplayMemberPath$
# Name��5�      $ �� SelectedValuePath$$ Id��5�      y�5�      �� *	IsEnabled+# [ $
! True��$ Hidden����5�      �� *PriorityList+% �� SelectedValue% 5�      �� 5�      $ Priority�6&   & �� ValidatesOnDataErrors& .   5�   "   	  5�   &   5�      5�      �� 5�      #��[ 6    $��7q�6G   $��4��6S   ��6c     *Status+�� 5�      $��5q�5�      $��5��5�      y�5�      �� *	IsEnabled+# [ $ Visible��{�5�      �� *	IsEnabled+$ False����5�      �� *Status+$ TwoWay=�$ PropertyChanged=�# [ �� 5�      $��5��5�      $
��20px��5�      $
# Name��5�      $$ Id��5�      y�5�      �� *	IsEnabled+# [ $
! True��$ Hidden����5�      �� *
StatusList+% 5�      �� 5�      $ Status�6&   & .   5�   "   	  5�   &   5�      5�      �� 5�      #��[ 6    $��7,7,7,0q�6G   $��Center=�6X   $��2��6u   $��6��6�   ��6�     *Description+6�   �� 5�      $��5q�5�      $
��60px��5�      $��3��5�      $��0��6(   $��6��68   "' �� VerticalScrollBarVisibility$
' Auto=�5�      ( �� TextWrapping$
( Wrap=�6>   {�5�      �� *	IsEnabled+$ False��.��5�      ��5�      �� 5�      $ MainInfo�6&   $ TwoWay=�66   & . $ PropertyChanged=�6a     5�   "   	  5�   &   5�      .��5�   (   5�      5�      5�      �� 5�      $��3��6   .+�5�      �� $��DataTrigger��6   $��Center=�6/   �� 5�      -   5        $��cbSample��5�      $��Center=�6+   ��6H     *CheckBoxTrigger+�� 5�      $��Center=�6   $��0q�69   $��14(�6D   ��5�      �� 5�      " ��6    .�5�      ��  � ��$ No��65   �� 5�       � ��
 �  ��6;   ) �� Triggers) 5�      �� 5�   "   * �� Binding* 6.   �� $ cbSample��$ 	IsChecked�+ �� Value+ True6g   .a�5�   &   ��  � ��$
 Yes!��6=   �� 5�   &    � ��
 � � �6C   5�   #   5�      5�      �� 5�      $��14(�6   $��Center=�6*   $��Выберите тему��6G   �� 5�      -   5        , ��Name$, styleBox��5�   8   $��Center=�6   68   �� 5      $��Center=�6   $ 
Horizontal=�6:   .+�5     �� -   5        - ��Name$- ProfileOpen��5  H   $��60��6=   $��2q�6`   ��6   �� *UndoCommand+.��5     �� $��Center=�6%   .+�5     '  !MaterialDesignThemes.Wpf.PackIcon  .   Kind$
. Undo=�66   $��Center=�6C   
���   �6c   �� 5     $��Center=�6(   $��12(�6E   
���   �$��
Назад��6f   5     5     �� 5     -   5        $- ProfileOpen1��5  =   $��60��6T   $��2q�6a   ��6   �� *RedoCommand+.��5     �� $��Center=�6%   .+�5	       $
. Redo=�66   $��Center=�6C   
���   �6c   �� 5
     $��Center=�6(   $��12(�6E   
���   �$��Вперед��6f   5     5     5     .  (WpfCustomControlLibrary1.ControlLibrary1  5     $��Center=�6.   $��5q�6K   �� 5     .+�5     �� $��Center=�6    $E��?Демонстрация RoutedUICommand. ПКМ + кнопка��6=   �� 5     -   5        $��txtSomeText��5     $	��220��6n   $��25��6z   $��10q�6�   �� 5     $��Center=�6   $
��10,5q�6:   $��10q�6I   #��Z
 6�   ��6U   �� / �� RelativeSource/ �� *Self+$ Command.Text�6�   5     5     5     5     5     