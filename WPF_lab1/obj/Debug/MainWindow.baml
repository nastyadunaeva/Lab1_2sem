   M S B A M L   `   `   `  ����C  ?WPF_lab1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPF_lab1WPF_lab1  5   	   G CClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1(clr-namespace:Lab3;assembly=ClassLibraryLab3 5   	   #clr-namespace:WPF_lab1WPF_lab1  5   	       WPF_lab1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WPF_lab1     5   	   7zz(clr-namespace:Lab3;assembly=ClassLibrary     5   	   %yyclr-namespace:WPF_lab1     5   	   -   5          � Title$  
MainWindow��5
   	   $��588.2��6   $	��800��6+    � 	Resources 5        Lab3.V3MainCollection   key_main_collection"   WPF_lab1.DataOnGridConverter  key_OnGrid_Converter"   WPF_lab1.DataCollConverter_1  key_DataColl_Converter_1"   WPF_lab1.DataCollConverter_2  key_DataColl_Converter_2  
key_view_1 �� Source �� Source  
key_view_2 # key_MainCollection_DataTemplate �� Orientation �� 	Converter��%�  &	        &	      &	 &     &	 9     &	 L     7   &	 �     7   &	 �     7  7    5   
   6<     5   
   6@     5   
   6D     5   
   6D   �� 5   
   -   5         5   2   �� 8   6�   �� 5   
   -   5         5   2   �� 8   6�   �� 5   
   .R�5      �� $ Vertical=�6   .+�5      �� ��6   �� 8   6c   �� 5      ��6   �� 8  6c   5      5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6    � RowDefinitions 5!   
   �� 5"      $��8* �6   �� 5#      $	��89* �6   �� 5$      $	��45* �6   �� 5%      $	��45* �6   .+�5(   
   � $��0��6   $��0��6   $��2��6,   $��0,0,264.6,0q�6@   .+�5)      o� $��25��6   $	��Top=�6   $��
0,0,-0.4,0q�67   $��2��6K   $��3��6\   .@�5*      m� $
��File��6   .@�5+      �� -   5        $��
button_New��5+      $	��New��60   6>   �� 5,      -   5        $��button_Open��5,      $
��Open��61   6@   �� 5-      -   5        $��button_Save��5-      $
��Save��61   6@   5.      m� 5/      $
��Edit��6   .@�50      �� -   5        $��Add Defaults��50      64   �� 51      -   5        $"��Add Default V3DataCollection��51      6D   �� 52      -	   5        $��Add Default V3DataOnGrid��52      6@   �� 53      -
   5        $��Add Element from File��53      6=   �� 54      -   5        $��Remove��54      6.   55      56      57      � 59   
   $��1��6   $��0��6   $��10,10,9.8,10.2q�6,   .+�5:      �� -   5         ��Name$ lisBox_Main��5:      ��6+   �� # [  6q   5;      � 5=   
   $��1��6   $��1��6   $��10.2,10,9.6,10.2q�6,   .+�5>      �� -   5        $ lisBox_DataCollection��5>      ��65   �� # [ 6r   5?      � 5A   
   $��1��6   $��2��6   $��10.4,10,9.6,10.2q�6,   .+�5B      �� -   5        $ lisBox_DataOnGrid��5B      ��61   �� # [ 6n   5C      � 5E   
   $��2��6   $��0��6   $��10q�6,   .+�5F      �� ��6   �� # [  	 �� Path$	 Max_dist�6f   5G      � 5I   
   $��2��6   $��1��6   $��10q�6,   .+�5J      �� -   5        $ listBox_details��5J      #��[ 6�   ��6/   �� 
 �� ElementName$
 lisBox_DataCollection��$	 SelectedItem.dataItems�6�   5K      � 5M   
   $��2��6   $��2��6   $��10q�6,   .+�5N      �� -   5         ��Name$ textbloxk_ongrid��5N      ��62   �� $
 lisBox_DataOnGrid��$	 SelectedItem.comp�# [ 6�   5P      5R      5S      