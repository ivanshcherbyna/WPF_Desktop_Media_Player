   M S B A M L   `   `   `  ����  WPF_MediaPlayer%    WPF_MediaPlayer.EqualizerWimdow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  EqualizerWimdow��5   	   $	��170��6!   $	��306��6.    � 
ResizeMode$ NoResize=�5   	   .��5      �  J� Opacity$	 0.6Q�6   $��	0,0,-6,-2q�6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5	      �  � Color$ 	#FF0063FF��6    � Offset$ 0Q�61   � 5
      $ 	#FFF1E2E2��6   $ 1Q�61   5       J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      .+�5   
   �� $��Volume��6   $
��Left=�6!   $��	11,13,0,0q�6<   $	��Top=�6O   �� 5   
   $��Balance��6   $
��Left=�6"   $��	11,54,0,0q�6=   $	��Top=�6P   �� 5   
   $��Speed��6   $
��Left=�6    $��	11,94,0,0q�6;   $	��Top=�6N   �� 5   
   -   5        $��	sldVolume��5      $
��Left=�6"   $��	62,15,0,0q�6=   $	��Top=�6P   $	��211��6h    � Value$	 0.5Q�6t   	 � Maximum$	 1Q�6�   6�   �� 5   
   -   5        $��
sldBalance��5      $
��Left=�6#   $��	62,56,0,0q�6>   $	��Top=�6Q   $	��211��6i   $ 0Q�6u   $	 1Q�6   
 � Minimum$
 -1Q�6�   6�   �� 5   
   -   5        $��sldSpeed��5      $
��Left=�6!   $��	62,96,0,0q�6<   $	��Top=�6O   $	��211��6g   $ 1Q�6s   $	 4Q�6}   6�   5      5      