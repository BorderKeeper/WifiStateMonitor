   M S B A M L   `   `   `  ����  WiFiStateMonitor.    (WiFiStateMonitor.Views.StatusUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      W SFontAwesome5.Net, Version=2.0.8.0, Culture=neutral, PublicKeyToken=9cfaf01297a008f8/fa5%http://schemas.fontawesome.com/icons/  5        � 	Resources  5	       �� MergedDictionaries �� Source�� 5
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
   -   5        $��LoggedInText��5*   !   $��2��6     LoggedInTextStyle#���  65   ��6a   �� *InfoBarText+�� 5,   
   -   5        $��
ViewEvents��5,      $��3��6     SpacedButtonStyle#���  6V   ��60   �� *ViewEventsCommand+.��6�   View Events6�   �� 5.   
   -   5        $��LogoutButton��5.      $��4��6   #���  6T   ��62   �� *LogoutCommand+.��6�   Logout6�   5/      50      