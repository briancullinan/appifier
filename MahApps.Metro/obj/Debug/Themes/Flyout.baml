   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=0.9.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MahApps.Metro.ControlsMahApps.Metro.Controls  5      =#clr-namespace:MahApps.Metro.ActionsMahApps.Metro.Actions  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35   HeaderTemplate  �� Orientation ��Name  MetroCircleButtonStyle � 	Resources  Key �� Color.   (System.Windows.Interactivity.Interaction    Triggers/  )System.Windows.Interactivity.EventTrigger   	EventName.  (System.Windows.Interactivity.TriggerBase   Actions/   )MahApps.Metro.Actions.SetFlyoutOpenAction   Value8  2System.Windows.Interactivity.TargetedTriggerAction   TargetObject	 �� RelativeSource
 �� AncestorType#   MahApps.Metro.Controls.Flyout j� Stretch !� Visual J� Clip �� Left �� Stretch
 �� Top ��Name �� Triggers �� Value �� Binding �� 
TargetName �� Property �� Value J� RenderTransformOrigin �� Angle �� 
TargetType �� 
TargetType �Name'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard  g� 	BeginTime! �� TargetProperty" �� 
TargetName9	  3System.Windows.Media.Animation.EasingDoubleKeyFrame# O� KeyTime$ O� Value% 	  EasingFunction.
  (System.Windows.Media.Animation.CubicEase7  1System.Windows.Media.Animation.EasingFunctionBase&   
EasingMode' ��Name(   HeaderTemplate�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      1Controls$clr-namespace:MahApps.Metro.Controls  5      Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      /Actions#clr-namespace:MahApps.Metro.Actions  5      %h  &	        '  w    7   �� 5      .R�5   
   �� $  
Horizontal=�6   $��10q�6.   .+�5	      �� $	 nav��6   
�������#���  65   $��40��6f   $��40��6r   $��Segoe UI Symbol)�6}   $��16(�6�   $	��Top=�6�    5
      ���� 5      
BlackBrush $ White��69   5       5        5      $ Click��6%   . 5         .   66   �� 	 �� "
  6�   5      .��5      �� $��20��6   $��15��6'   ��5      !� 5      $
 Fill=�6&    5      �� 5   "   4 ��        � l�    � l� l��     l��        $��40��6K   $��48��6W   .+�5   &   F� a���� Q%��O� Q%����p\-�������@��� �8@����ا  6n� �8��� ������� �p\-��O� Q%��O#��� ��6|   $��18��6�   $ 11��6�   $
 Fill=�6�   $ 15��6�   $��25��6�   5   #   5      5      5      �� 5      $ PART_BackButton��6)   $��20(�6B   $��15,0,0,0q�6P   $��Center=�6b   ��6   �� 6b   5       5    
   �� 5!      $ Right��6~    6   �� *
Position+	 �� "
  .a�5"      �� $	 nav��6    � �� 5#      �� 5$      $��20��6$   $��15��6/   $ 0.5,0.5&�6;   z�5%      V� 5&   "   .~�5'   &   �� �� 5(   &   �� 5)   &   $
 -180Q�66   T� 5*   &   5+   #   ��5-      !� 5.   "   $
 Fill=�6.    5/   &   �� 50   *   4 ��        � l�    � l� l��     l��        $��40��6S   $��48��6_   .+�51   .   F� a���� Q%��O� Q%����p\-�������@��� �8@����ا  6n� �8��� ������� �p\-��O� Q%��O#��� ��6�   $��18��6�   $ 11��6�   $
 Fill=�6�   $ 15��6�   $��25��6  52   +   54   #   56      58      59      5;      �� 5=      "  6   .�5>   
   ��  � ��$ Stretch=�6.   �� 5?   
    � ��$ Stretch=�65   �� 5@   
    �@ HeaderTemplate8   6+   �� 5A   
    � �� �	#FF2525256'   �� 5B   
    � �� �	#FFFFFFFF6'   �� 5C   
    � �� 5D      �� 5E      "  6"   .R�5F      � $
 root��6   #��z��6)   $
��Left=�6S   z�5G      T� 5H       5J        5K      . 5L   "     Default��6.     5M   "   Hide��. 5N   &   �� .��5O   *   U� $  00:00:00X�6H   $8! 2(UIElement.RenderTransform).(TranslateTransform.X)�6]   $
" root��6�   .\�5P   .   	  $# 00:00:00.500��6C   $$ 1Q�6Z   	hideFrame��% 5Q   2   
  5R   6   $& EaseOut=�6@   5T   /   5U   +   5V   '   5W   #     5X   "   Show��. 5Y   &   �� .��5Z   *   U� $  00:00:00X�6H   $8! 2(UIElement.RenderTransform).(TranslateTransform.X)�6]   $
" root��6�   .\�5[   .   	  $# 00:00:00.600��6C   $$ 1Q�6Z   	showFrame��% 5\   2   
  5]   6   $& EaseOut=�6@   5_   /   5`   +   5a   '   5b   #   5c      .+�5e      �� .+�5f      �� $' PART_Header��6/   $��Header��6D   #��z( 6[   �� 5g      $' PART_Content��6/   5h      5i      5j      5l      5m      5n      