   M S B A M L   `   `   `  ����G  CStockTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StockTracker.ViewStockTracker.View  5   	   U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5   	   !    StockTracker.View.LoginView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StockTracker.View     5   	   Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   Bei9http://schemas.microsoft.com/expression/2010/interactions  5	   	   -   5          � Title$  	LoginView��5   	   $
��1020��6   $	��720��6(   
������  � WindowStyle$
 None=�6N    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6�    � WindowState 6a   �� *CurrWindowState+.  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ MouseLeftButtonDown��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *MoveWindowCommand+5      .��5       �� 
������ $	��1.5q�5!      	 �� CornerRadius$	 10��5"      ���	#FF0E103E._�5%   
   ]� ��. .+�5&      � $	��Top=�6   ���	#FF09092C
 � ColumnDefinitions
 5'      �� 5(      $
��auto �6'   66   �� 5)      $��* �6'   63   �� 5*      $
��auto �6'   66    � RowDefinitions 5,      �� 5-      6&   .+�50      ��  �� Orientation$ 
Horizontal=�6   $��0��66   $��0��6C   .+�51      �� 
������ $��0q�66   $��32��6J   $��44��6U   $��10q�6a   .��52      �� $$��/Resources/Images/menu_btn.png��6    53      �� 54      ���	#FFF2053F$��Center=�67   $��24(�6R   $��Roboto)�6`   $��10q�6t   StockTracker6�   55      �� 56      $��0��6   $��1��6*   $ 
Horizontal=�6:   .+�57      �� -   5         ��Name$ stockQueryBox��57      $	��370��65   $��44��6A   $��10q�6M   ���	#FF3A3A56
�������$��10q�6�   $��Roboto Light)�6�   $��18(�6�   $��0q�6�   $��Center=�6�   ��6�   �� *StockQueryText+6,  �� 58      
������ $��0q�66   $��32��6J   $��44��6U   $��10q�6a   ��6m   �� *SearchStockCommand+.��59      �� $"��/Resources/Images/search.png��6    6H   5:      5;      �� 5=      $��0��6   $��2��6*   $ 
Horizontal=�6:   .+�5>      �� 
������ $��0q�66   $��40��6J   $��40��6U   $	��5 0q�6a   .��5?      �� $"��/Resources/Images/notify.png��6    6H   5@      �� 5A      -   5        
������ $��0q�5A   6   $��40��6J   $��40��6U   $	��5 0q�6a   .��5B      �� $$��/Resources/Images/minimize.png��6    6J   5C      �� 5D      -   5        
������ $��0q�5D   6   $��40��6J   $��40��6U   $	��5 0q�6a   .��5E      �� $!��/Resources/Images/close.png��6    6G   5F      5G      5K      � 5M       5N      �� 5O      6&   �� 5P      6&   �� 5Q      6&   
 5S      �� 5T      $��2* �6'   64   �� 5U      $��3* �6'   64   .+�5Y      �� $��0��6   $��0��6&   ���	#FF30305A$��1q�6N   $	 10��6b   $��20q�6t    �� Padding$ 10q�6�   ._�5Z      �� .+�5[      ]� .+�5\      �� ���	#FFAC0589$��20��69   $��20��6E   
���   �$
��Left=�6_   $��0 0 15 0q�6z   �� 5]      
����ح�$��Center=�6?   $��24(�6Z   $��Roboto Light)�6h   	Balance6�   �� 5^      
�������$��Center=�6:   $��18(�6U   $��Roboto Light)�6c   $��Right=�6}   ��6�   �� *CurrentDate+August 2, 20176�   5_      ]� 5a      .+�5b      �� -   5         ��Name$ txt_balance��5b   (   $��Comic Sans MS)�6=   $��32(�6X   ���	#FFE0E0E0$��10q�6}   	$4,369.006�   ]� 5c      $��Right=�6(   .+�5d   "   �� $��Right=�6(   $$��/Resources/Images/up_arrow.png��6D   $��40��6l   $��30��6w   $
��10 0q�6�   6�   �� 5e   "   $��Right=�6,   
����ح�$��22(�6_   $��Roboto Light)�6m   $��Center=�6�   +3196�   5f      5g      5j      5k      �� 5n      $��1��6   $��0��6&   ���	#FF30305A$��1q�6N   $	 10��6b   $��20 10 20 20q�6t   $ 10q�6�   ���	#FF09092C._�5o      �� .+�5p      ]� .+�5q      �� ���	#FFF2053F$��20��69   $��20��6E   
���   �$
��Left=�6_   $��0 0 15 0q�6z   �� 5r      
����ح�$��Center=�6?   $��24(�6Z   $��Roboto)�6h   	Positions6�   5s      5v      5w      �� 5y      $��2��6   $��0��6&   ���	#FF30305A$��1q�6N   $	 10��6b   $��20 10 20 20q�6t   $ 10q�6�   ._�5z      �� .+�5{      ]� .+�5|      �� ���	#FF390FF5$��20��69   $��20��6E   
���   �$
��Left=�6_   $��0 0 15 0q�6z   �� 5}      
����ح�$��Center=�6?   $��24(�6Z   $��Roboto)�6h   	Watchlist6�   5~      ]� 5      .+�5�      �� .+�5�   "   ��    SquareButtonTemplate#��[  6)   
�������$��20(�6j   $��Roboto)�6x   ��6�   Z� .��6�   TSLA6�   �� 5�   "   #��[  6)   
�������$��20(�6j   $��Roboto)�6x   ��6�   Z� .��6�   MSFT6�   �� 5�   "   #��[  6)   
�������$��20(�6j   $��Roboto)�6x   ��6�   Z� .��6�   AAPL6�   5�      5�      5�      5�      �� 5�      $��2��6   $��1��6.   .+�5�      #  LiveCharts.Wpf.CartesianChart  $	��396��6)   $��0,0,20,0q�66   &   LiveCharts.Wpf.Charts.Base.Chart   Series 5�        LiveCharts.Wpf.LineSeries    LiveCharts.Wpf.Series   StrokeThickness$ 2Q�6G      Fill
 ����    LineSmoothness$ 0Q�6n      PointForeground �#222E31   Values 6-   �� *Values+   PointGeometry 6�   Z�    Stroke 5�   "   �� 5�   &    �� EndPoint$ 0.5,1&�6:    �� 
StartPoint$ 0.5,0&�6K   .��5�   *   �  � Color$ 	#FF600A74��67    � Offset$ 0.474Q�6I   � 5�   *   $ 	#FFF31616��67   � 5�   *   $ 	#FFF31616��67   $ 0.965Q�6I   5�   '   5�         DataTooltip 5�      #	  LiveCharts.Wpf.DefaultTooltip	  5�       	  SelectionMode$ 
OnlySenderX�61    	  
ShowSeries .  6L      AxisX 5�      
  LiveCharts.Wpf.Axis
    
  FontSize$  14Q�6A   ! 
  
FontFamily$! Roboto Light)�6O   " 
  
Foreground
" ��ح�# 
  LabelsRotation$	# -20Q�6�   $ 
  Labels$ 6'   �� *Labels+% 
  	Separator% 5�   "     LiveCharts.Wpf.Separator  5�   &   &   StrokeThickness$	& 0.5Q�64   '   Step' 6J   �� *Step+(   Stroke( 5�   *   �� 5�   .   ) �� Color$) 	#FF0A326C��6>   5�   '   5�      *   AxisY* 5�      
  $  16Q�6'   $! Roboto Light)�65   
" ��ح�% 5�   "     5�   &   $& 1Q�64   +   StrokeDashArray$+ 2R�6H   ( 5�   *   �� 5�   .   $) 	#FF0A326C��6>   5�   '   5�      5�      �� 5�      $ 
Horizontal=�6!   $��	20 10 0 0q�6:   .+�5�      ��   RoundedButtonTemplate#��[ 6!   $��70��6S   $��30��6^   
����ح����	#FF09092C$��1 day��6�   ��6�   �� *SearchStockCommand+.��6�   1 day6�   �� 5�      #��[ 6!   $��70��6S   $��30��6^   
����ح����	#FF09092C$��5 day��6�   ��6�   �� *SearchStockCommand+.��6�   5 day6�   �� 5�      #��[ 6!   $��70��6S   $��30��6^   
����ح����	#FF09092C$��1 month��6�   ��6�   �� *SearchStockCommand+.��6�   	1 month6�   �� 5�      #��[ 6!   $��70��6S   $��30��6^   
����ح����	#FF09092C$��3 month��6�   ��6�   �� *SearchStockCommand+.��6�   	3 month6�   �� 5�      #��[ 6!   $��70��6S   $��30��6^   
����ح����	#FF09092C$��1 year��6�   ��6�   �� *SearchStockCommand+.��6�   1 year6�   �� 5�      #��[ 6!   $��70��6S   $��30��6^   
����ح����	#FF09092C$��5 year��6�   ��6�   �� *SearchStockCommand+.��6�   5 year6�   5�      5�      �� 5�      $��2��6   $��1��6&   ���	#FF30305A$��1q�6N   ���	#FF09092C$	 10��6y   $��20 10 20 20q�6�   $ 10q�6�   ._�5�      �� .+�5�      ]� .+�5�      �� ���	#FFE66216$��20��69   $��20��6E   
���   �$
��Left=�6_   $��0 0 15 0q�6z   �� 5�      
����ح�$��Center=�6?   $��24(�6Z   $��Roboto)�6h   News6�   5�      5�      5�      5�      5�      5�      5�      