   M S B A M L   `   `   `  ����L  Hychebnay practica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ychebnay_practicaychebnay_practica  5   	       ychebnay_practica.classs   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ychebnay_practica     5   	     � Title$  classs��5   	   $	��450��6   $	��800��6%   .��5	      � -   5         �Name$ ycheb1��5	      ��5
   
   �� 5       �� ImageSource$ /фон.jpg��6    j� Stretch$ UniformToFill=�60    � ColumnDefinitions 5   
   �� 5      $	��69* �6   �� 5      $
��258* �6   �� 5      $	��87* �6   �� 5      $
��170* �6   �� 5      $	��62* �6   �� 5      $	��97* �6   �� 5      $	��42* �6   �� 5      $	��15* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       .+�5#   
   &   System.Windows.Controls.DataGrid  -   5          Name$ ycheb��5#      $��1��6"   $��	0,48,0,48q�6]   $��9��6p   �� 5$   
   -   5         ��Name$ tx��5$      $��3��6   $��Center=�6.    �� TextWrapping$
 Wrap=�6K   $��Копейщик��6_   $��Center=�6o   $	��170��6�   $��48��6�   $��1��6�   ���	#FF192854
�������$��Arial)�6�   $��20(�6�   	 �� TextAlignment$	 Center=�6�   �� 5%   
   -   5        $	 tx2��5%      $��3��6   $��Center=�6/   $��3��6L   $
 Wrap=�6Y   $��Сап-ДПС��6m   $��Center=�6|   $	��170��6�   $��49��6�   ���	#FF0B1840$��Arial)�6�   $��20(�6�   $	 Center=�6�   �� 5&   
   -   5        
 ��Name$	
 dob��5&      $��5��6   $��Добавить��6.   $��Center=�6A   $��1��6^   $��Center=�6k   $��48��6�   $��97��6�   ���	#FFDDDDDD$��Arial Black)�6�   $��16(�6�   6�   �� 5'   
   -   5        $	
 del��5'      $��5��6   $��Удалить��6.   $��Center=�6@   $��3��6]   $��Bottom=�6j   $��48��6�   $��97��6�   $��Arial Black)�6�   $��16(�6�   $��0,0,0,48q�6�   $��2��6�   6�   �� 5(   
   -   5        $	
 izm��5(      $��5��6   $��Изменить��6.   $��Center=�6A   $��5��6^   $��Center=�6k   $��48��6�   $��97��6�   $��Arial Black)�6�   $��16(�6�   6�   5)      5*      