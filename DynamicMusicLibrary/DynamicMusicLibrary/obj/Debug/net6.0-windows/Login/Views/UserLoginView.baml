   M S B A M L   `   `   `  ����N  JDynamicMusicLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:DynamicMusicLibrary.CustomControls"DynamicMusicLibrary.CustomControls  5      E'clr-namespace:DynamicMusicLibrary.ViewsDynamicMusicLibrary.Views  5      O,clr-namespace:DynamicMusicLibrary.ViewModelsDynamicMusicLibrary.ViewModels  5	      -    'DynamicMusicLibrary.Views.UserLoginView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Kcustomcontrols0clr-namespace:DynamicMusicLibrary.CustomControls     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:DynamicMusicLibrary.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      C
viewModels,clr-namespace:DynamicMusicLibrary.ViewModels     5	      -   5          � Title$  UserLoginView��5
      $
��1000��5      $	��550��5       � AllowsTransparency$
 True��5      
������  � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5       � DataContext 5      3   -DynamicMusicLibrary.ViewModels.LoginViewModel  5   
    � 	Resources 5         Bool2Visibility��%   &	        �� 5   
   6'   5      y�5      �� 5   
    �� 	Converter# [  5       �� Mode$ TwoWay=�5       	 �� Path$	 IsViewVisible�5!      .��5$      �� 
 �� CornerRadius$
 50��6   ��5%   
   �� 5&       �� ImageSource$" \Images\login-background.jpg��6    j� Stretch$ UniformToFill=�6D   ._�5(   
   �� $��1q�5)      $
 10��5*       J� Opacity$
 0.95Q�5+      ��5,      �� 5-       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5.      �  � Offset$ 0Q�6#    � Color$ 	#FF2E9E49��6.   � 5/      $ 0Q�6#   $ 	#FFCE782E��6.   � 50      $ 0Q�6#   $ 	#FFA3C126��6.   51      ��54      �� 55      $	 0,1&�6&   $	 1,0&�67   .��56      � $ 0Q�6#   $ 	#FF6F6CFF��6.   � 57      $
 0.75Q�6#   $ 	#FF41671C��61   58      ._�5;      �  � RowDefinitions 5<      �� 5=      $��30 �6$   �� 5>      .+�5A      �  � ColumnDefinitions 5B      �� 5C      �� 5D      $��25 �6+   �� 5E      $��25 �6+   �� 5F      $��5 �6+   .+�5I      �� $��0��5J      $��10,0,0,0q�5K      $��Center=�5L      $��
Montserrat)�5M      $��10(�5N      
�������$��LOG IN��5P      �� 5R      -   5         ��Name$ btnMinimize��5S      $��1��5T      $��0,1,0,0q�5U      $��0q�5V      $��-��5X       � Cursor$
 Hand��5Y      $��
Montserrat)�5Z      $��16(�5[      
���������5^      �� 5_       �� 
TargetType" ��6$   .�5`   "   ��  �� Property � �� �� Value �#28AEED6?    �� Triggers 5b   "   P� 5c   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5d   *   ��  � �� �#278BEF6G   5e   '   5g      ��5j      �� 5k       �� 
TargetType" ��6.   .R�5l   "   �� $��18��5m   %   $��18��5n   %   #��z��5o   %   $
 9��5p   %   ._�5q   &   �� $��Center=�67   $��Center=�6T   5r   #   5s      5u      �� 5w      -   5        $ btnClose��5x      $��2��5y      $��0,1,0,0q�5z      $��0q�5{      $��X��5}      $
 Hand��5~      $��
Montserrat)�5      $��16(�5�      
���������5�      �� 5�      " ��6$   .�5�   "   ��  � �� �#DA34AE6?    5�   "   P� 5�   &    �@J�IsMouseOver$
 True��6E   . �5�   *   ��  � �� �#C62DAE6G   5�   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $��18��5�   %   $��18��5�   %   #��z��5�   %   $
 9��5�   %   ._�5�   &   �� $��Center=�67   $��Center=�6T   5�   #   5�      5�      5�      �� 5�      $��2��5�      $	��250��5�      $��0,35,0,0q�5�       �� Orientation$ Vertical=�5�      .+�5�      �� $��Center=�5�      $��
Montserrat)�5�      $��22(�5�      $��Medium"�5�      
�������$��Dynamic Music Library��5�      �� 5�      $��0,5,0,0q�5�      $��Center=�5�      $��
Montserrat)�5�      $��12(�5�      $��Medium"�5�      
�������$$��Open Source Music Organization��5�      �� 5�      $��0,35,0,0q�5�      $��
Montserrat)�5�      $��12(�5�      $��Medium"�5�      
�������$��Username��5�      �� 5�      -   5         ��Name$ txtUser��5�      $��28��5�      $��20,0,0,0q�5�      $��Center=�5�      
�������$��0,0,0,2q�5�       �� 
CaretBrush
 �����$��
Montserrat)�5�      $��13(�5�      $��Medium"�5�      
���������5�      �� *
UserName+  �� UpdateSourceTrigger$  PropertyChanged=�.��6X   ��5�      �� 5�      ! j� 
AlignmentX$
! Left=�5�   !   $ /Images/userimage.png��5�   !   $
 None=�5�   !   .��5�   .   5�      �� 5�      $��0,35,0,0q�5�      $��
Montserrat)�5�      $��12(�5�      $��Medium"�5�      
�������$��Password��5�      <   6DynamicMusicLibrary.CustomControls.BindablePasswordBox  5�      $��28��5�      $��0,5,0,0q�5�      "   Password" 5�      �� *
Password+$ TwoWay=�$  PropertyChanged=��� 5�      $��0,30,0,0q�5�      $��
Montserrat)�5�      $��12(�5�      $��Medium"�5�      ���#D7596D$
��Wrap=�5�      ��5�      �� *ErrorMessage+5�      �� 5�      -   5        $ btnLogin��5�      $��2��5�      $��0,30,0,0q�5�      $��0q�5�      $��LOGIN��5�      $
 Hand��5�      $��
Montserrat)�5�      $��16(�5�      
���������5�      �� *LoginCommand+��5�      �� 5�      " ��6$   .�5�   "   ��  � �� �	#FF80CA2B6?    5�   "   P� 5�   &    �@J�IsMouseOver$
 True��6E   . �5�   *   ��  � �� �	#FF4C7B0B6G   5�   '   5�      ��5     �� 5     " ��6.   .R�5  "   �� $	��150��5  %   $��40��5  %   #��z��5  %   $
 20��5  %   ._�5  &   �� $��Center=�67   $��Center=�6T   5	  #   5
     5     �� 5     $��0,15,0,0q�5     $��Center=�5     $ 
Horizontal=�5     .+�5     �� $��
Montserrat)�5     $��12(�5     $��Medium"�5     
�������$��Forgot Password?��5     �� 5     $��8,0,0,0q�5     $
 Hand��5     $��
Montserrat)�5     $��12(�5     $��Medium"�5     
�������$��Reset��5!     5#     5$     5&     5'     5(     5)     