   M S B A M L   `   `   `  ����K  GWiFiStateMonitor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WiFiStateMonitor.ViewsWiFiStateMonitor.Views  5   	   (    "WiFiStateMonitor.Views.EventWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6views$clr-namespace:WiFiStateMonitor.Views     5   	   W SFontAwesome5.Net, Version=2.0.8.0, Culture=neutral, PublicKeyToken=9cfaf01297a008f8/fa5%http://schemas.fontawesome.com/icons/  5   	     � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � Left$	 100��5   	   
 � Top$	 100��5   	   
���   � � Title$ Wi-Fi State Monitor��5   	   $	��400��6%   $	��800��62   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      ResizeBorderThickness$ 7q�5         CaptionHeight$ 30Q�5         CornerRadius$ 0��5      	   GlassFrameThickness$	 0q�5      
 � 	Resources
 5       �� MergedDictionaries �� Source   Key �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value�� 5   
    5      �� 5      $% ../Styles/CommonDictionary.xaml?�6%   �� 5      �� 5      
EventStyle  " ��6/   .�5      ��  � �� �#CDCDCD67   5      �� 5      EventListStyle  " ��63   .�5       ��  � ��$ 10q�64    5!      P� 5"       �@��AlternationIndex$ 1��6K   . �5#   "   ��  � �� �#E2E2E26?   5$      5&      �� 5'      EventTextBlockStyle  " ��68   .�5(      ��  � ��$ 20(�65   �� 5)       � ��$ 
ExtraLight"�67   �� 5*       � ��$
 Left=�6@   �� 5+       � ��$ Center=�6>   �� 5,       � ��$ 10 0 0 0q�63   5-      5.      %    50      .��53      �  � RowDefinitions 54   
   �� 55      $
��Auto �6   �� 56      $��* �6   .+�59   
   � -   5        $��TopBar��59      $��0��6    � ColumnDefinitions 5:      �� 5;      $��* �6#   �� 5<      $
��Auto �6#   .+�5?      � -   5        $��EmptyTopBarSection��5?      $��0��6   ���#828282.+�5@      ��   EventTextBlockStyle#���  6   Wi-Fi State Monitor6_   5A      � 5B      -   5        $��
ExitButton��5B      $��1��6   $��40��60   $��40��6;   $��Right=�6G   .+�5C      ��    IsHitTestVisibleInChrome$
 True��6   $��0q�6m   ��6F   �� *CloseWindowCommand+.��5D        FontAwesome5.FontAwesome     Icon$ Solid_Times=�6&   
���   �69   5E      5F      5G      �� 5I   
   -   5        $��	EventList��5I       $��1��6   $��Disabled=�61     EventListStyle#���  5J   5     
EventStyle#���  5K       �� AlternationCount$ 2��68   ��5J      �� *	EventList+��5L      �� 5M      .R�5N      �� .��5O      �� $
��Left=�6$   ��6?   �� *Text+5P      5Q      5S      5T      5U      