   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=0.9.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MahApps.Metro.ControlsMahApps.Metro.Controls  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089/    )MahApps.Metro.Controls.ToggleSwitchButton  �� 
TargetType �� Property �� Value   AccentColorBrush �� 
TargetType ��Name J� Opacity �� Padding'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState	   
Storyboard
 �� TargetProperty �� 
TargetName R� KeyTime  System.Windows.Visibility   Visible R� Value   Transitions%  System.Windows.VisualTransition   GeneratedDuration	   To   
Storyboard g� Duration	 W� To W� EasingFunction/  )System.Windows.Media.Animation.CircleEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode4  .System.Windows.Media.Animation.ExponentialEase   Exponent9	  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value �Name � UseLayoutRounding ��Name  
GrayBrush9  
BlackBrush)
   #MahApps.Metro.Controls.ToggleSwitch � RowDefinitions � ColumnDefinitions ��Name  
  Header! 
  HeaderTemplate"   Name# 
  SwitchForeground$    SwitchForeground�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      1Controls$clr-namespace:MahApps.Metro.Controls  5      %�  '         '
  r    �� 5      "    6   .�5   
   ��  � �� .  6&   �� 5   
    �@  SwitchForeground# �   6-   �� 5   
    � �� 5      �� 5	      "   6"   .R�5
      �� $
 Root��6   #��z��5      #��z��5      # z 5      # z��5       5        5      CommonStates��. 5   "     
Normal��6.     5   "   Disabled��6.     5   "   	MouseOver��.	 5   &   �� .��5   *   T� $
 (UIElement.Visibility)�6H   $ hover��6{   ..�5   .   i� $ 0��6E   # Z 6Q   5   +   5   '   5   #     5   "   Pressed��.	 5   &   �� .��5   *   T� $
 (UIElement.Visibility)�6H   $ pressed��6{   ..�5   .   i� $ 0��6E   # Z 6Q   5   +   5   '   5    #   5!        5"      CheckStates�� 5#   "     5$   &   $ 0:0:0.05D�67   $ 	Unchecked��6T     5%   &   $ 0:0:0.05D�67   $ Checked��6T   . 5&   *   �� .��5'   .   W� $ 0:0:0.05D�6>   $ 47X�6R   $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6Z   $ SwitchThumb��6�    5(   2     5)   6   $ EaseIn=�6A   5+   /   5,   +   5-   '   . 5/   "     Checked��.	 50   &   �� .��51   *   W� $ BackgroundTranslation��6:   $
 (TranslateTransform.X)�52      $ 0D�53      $ 68X�54       55   .     56   2   $ 15Q�6B   $ EaseOut=�6P   58   +   U� 59   *   $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6H   $ SwitchThumb��6�   .\�5:   .   	  $ 0��6C   $ 47Q�6O   5;   +   5<   '   5=   #     5>   "   Dragging��6.     5?   "   	Unchecked��.	 5@   &   �� .��5A   *   W� $ BackgroundTranslation��6:   $
 (TranslateTransform.X)�5B      $ 0D�5C      $ 0X�5D      T� 5E   *   $
 (UIElement.Visibility)�6H   $ border��6{   ..�5F   .   i� $ 0��6E   # Z 6Q   5G   +   5H   '   5I   #   5J      ._�5L      � $ 
SwitchRoot��6   $
��Auto��6I   $
��Auto��6W    . ��63   Z� .+�5M      � $ SwitchTrack��6#   $
��Auto��68   .+�5N   "   � $ SwitchBottom��6'   $��25��6=   $��60��6I   .+�5O   &   �� $ SwitchBackground��60   $
��Auto��5P      $
��Auto��5Q      $��Stretch=�5R      $��Stretch=�5S      z�5T   *   T� 5U   .   BackgroundTranslation��6A   5W   '   �� 5X   &   $��2q�6-   #���  6A   ._�5Y   *   � $��2q�6/   .+�5Z   .   �� $��0q�65   #���   6I   $��0q�6y   �� 5[   .   $ border��65   $��0q�6E   #���  6Y   $y�	Collapsed=�6�   $��0q�6�   �� 5\   .   $ pressed��65   $��0q�6F   #��� ��6Z   $
 0.25Q�6�   $y�	Collapsed=�6�   $��0q�6�   �� 5]   .   $ hover��65   $��0q�6D   #��� ��6X   $
 0.15Q�6�   $y�	Collapsed=�6�   $��0q�6�   5^   +   5_   '   5`   #   �� 5a   "   $ SwitchThumb��6)   #��z��5b      $��0q�5c      $��0q�5d      $��13��5e      $
��Auto��5f      $
��Left=�5g      z�5h   &   V� 5i   *   .~�5j   .   �� �� 5k   .   �� 5l   .   T� 5m   .   5n   +   ._�5p   &   �� $ ThumbCenter��6-   #��z��6B   $��0q�6m   #���  6�   5q   #   5r      5s      5t      5u      5w      5x      �� 5z      "  
 6   .�5{   
   ��  � �� .  6&   �� 5|   
    �@
 SwitchForeground# �   6-   �� 5}   
    � ��$
 Left=�67   �� 5~   
    � ��$	 Top=�65   �� 5   
    � ��# �  6'   �� 5�   
    � �� 5�      �� 5�      " 
 6"   .R�5�      �� #��z��6   #��z��5�      # z��5�       5�        5�      CommonStates��. 5�   "     
Normal��6.     5�   "   Disabled��.	 5�   &   �� .��5�   *   W� $ Header��6:   $
 (UIElement.Opacity)�6Y   $ 0D�6�   $	 0.3X�6�   W� 5�   *   $ Content��6:   $
 (UIElement.Opacity)�6Z   $ 0D�6�   $	 0.3X�6�   W� 5�   *   $ Switch��6:   $
 (UIElement.Opacity)�6Y   $ 0D�6�   $
 0.75X�6�   5�   '   5�   #   5�      ._�5�      � $��12,5,0,0q�6    5�      �� 5�   "   $
��Auto �60   �� 5�   "   $
��Auto �60    5�      �� 5�   "   $��* �63   �� 5�   "   $
��Auto �63   .+�5�      �� $ Header��6-   $��Normal"�5�      #��z  5�      #��z! 5�      $
��Left=�5�      ��.  $��0,0,0,5q�5�      $
 0.65Q�5�      $	��Top=�5�      $��3��6)   $��16(�6=   $��0q�6K   �� 5�      $ Content��6-   $��1��5�      #��z��5�      #��z��5�      #��z��5�      ��.  $��	-1,1,0,-7q�5�      #��z��5�      $��Segoe UI Semibold)�6P   $��14.667(�6o      5�      $" Switch��6:   $��1��5�      $��1��5�      #��z��5�      #$ z# 5�      $��Bottom=�5�      $��Right=�6,   $��1��6H   5�      5�      5�      5�      5�      5�      