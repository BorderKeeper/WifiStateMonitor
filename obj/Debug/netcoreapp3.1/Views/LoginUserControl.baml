   M S B A M L   `   `   `  ����  WiFiStateMonitor-    'WiFiStateMonitor.Views.LoginUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      W SFontAwesome5.Net, Version=2.0.8.0, Culture=neutral, PublicKeyToken=9cfaf01297a008f8/fa5%http://schemas.fontawesome.com/icons/  5        � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $% ../Styles/CommonDictionary.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   � -   5        $��TopBar��5      $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5       � -   5        $��EmptyTopBarSection��5       $��0��6   ���#82828268   � 5!      -   5        $��
ExitButton��5!      $��1��6   $��40��60   $��40��6;   $��Right=�6G   .+�5"      �� '  !System.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome$
 True��6   $��0q�6f   ��6F   �� *ExitCommand+.��5#        FontAwesome5.FontAwesome     Icon$ Solid_Times=�6&   
���   �69   5$      5%      5&      �� 5(   
   -   5        $��LogoText��5(   !   $��1��6      TitleTextStyle#���   61   Wi-Fi State Monitor6o   �� 5*   
   -   5        $��UsernameBox��5*      $��2��6     UsernameInputStyle#���  62   ��6_   �� *
Username+ �� Mode$ TwoWay=�G� 5,   
   -   5        $��PasswordBox��5,   #   $��3��6     PasswordInputStyle#���  66   6c   � 5.   
   -   5        $��ControlGrid��5.      $��4��6     ControlGridStyle#���  6*    5/      �� 50      $��* �6#   �� 51      $
��Auto �6#   .+�54      �� -   5        $��LoginResponseText��54   (   $��0��6     LoginResponseStyle#���  6d   ��6A   �� *LoginResponseText+6d   �� 55      -	   5        $��LoginButton��55   %   $��1��6     ButtonStyle#���  6Y   ��68   �� *LoginCommand+.��6   Login6�   56      57      58      