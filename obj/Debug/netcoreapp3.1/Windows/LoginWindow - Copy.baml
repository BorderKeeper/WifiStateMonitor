   M S B A M L   `   `   `  ����  WiFiStateMonitor*    $WiFiStateMonitor.Windows.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   W SFontAwesome5.Net, Version=2.0.8.0, Culture=neutral, PublicKeyToken=9cfaf01297a008f8/fa5%http://schemas.fontawesome.com/icons/  5   	     � WindowStyle$
  None=�5   	    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ Wi-Fi State Monitor��5   	   $	��400��6%   $	��400��62   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      ResizeBorderThickness$ 7q�5         CaptionHeight$ 30Q�5         CornerRadius$ 0��5         GlassFrameThickness$ 0q�5      	 � 	Resources	 5      
 �� MergedDictionaries �� Source�� 5   
   
 5      �� 5      $% ../Styles/CommonDictionary.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6   �� 5!      $
��Auto �6   �� 5"      $
��Auto �6   .+�5%   
   � -   5        $��TopBar��5%      $��0��6    � ColumnDefinitions 5&      �� 5'      $��* �6#   �� 5(      $
��Auto �6#   .+�5+      � -   5        $��EmptyTopBarSection��5+      $��0��6   ���#82828268   � 5,      -   5        $��
ExitButton��5,      $��1��6   $��40��60   $��40��6;   ���#FF3A3A$��Right=�6\   .+�5-        FontAwesome5.FontAwesome     Icon$ Solid_Times=�6"   5.      5/      �� 51   
   -   5        $��LogoText��51   !   $��1��6      TitleTextStyle#���   61   Wi-Fi State Monitor6o   �� 53   
   -   5        $��UsernameBox��53      $��2��6     UsernameInputStyle#���  62   $��Username��6_   G� 55   
   -   5        $��PasswordBox��55   #   $��3��6     PasswordInputStyle#���  66    G� Password$
 aaaa��6c   � 57   
   -   5        $��ControlGrid��57      $��4��6     ControlGridStyle#���  6*    58      �� 59      $��* �6#   �� 5:      $
��Auto �6#   .+�5=      �� -   5        $��LoginResponseText��5=   (   $��0��6   $��Login Failed��6A     LoginResponseStyle#���  6U   �� 5>      -	   5        $��LoginButton��5>   %   $��1��6     ButtonStyle#���  68   .��6^   Login6e   5?      5@      5A      