   M S B A M L   `   `   `  ����B  >Highway, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Highway.UserControlsHighway.UserControls  5      3    -Highway.UserControls.UserControlAddRoadToList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Highway.UserControls     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962ac _MaterialDesignThemes.MahApps, Version=0.1.9.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5      $	��470��5	      $��549.85��6   .��5
      � $��
0,0,10.2,0q�6   .+�5   
   � $��0,380,-1,35.4q�6   .+�5      �� -   5        $��AddRoadToList��5         RoundButtonTemplate#��[  5      ���#fff$��Add to list��5      $��30(�5      $��Palatino Linotype)�5      $��140,10,130.8,0q�60   6H   5      � 5   
   $��
0,0,0,90.4q�6   .+�5      ]� $��0,0,-0.2,315q�6   .+�5      �� $
��Left=�5      $��Road name :��5      $��30(�5      $��Palatino Linotype)�5      $��Center=�5      $��Center=�5      $
��auto��5      �� 5      -   5        $��RoadName��5!      $
��Left=�5         Textbox#��[ 5"      "  �� VerticalScrollBarVisibility$
  Auto=�5#       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5%      $��Palatino Linotype)�5&      $��30(�5'      $��55��5(      $��105,5,0,4.8q�5)      $	��214��6.   5*      ]� 5+      $��0,65,-0.2,250q�6   .+�5,      �� $
��Left=�5-      $��Road type :��5.      $��30(�5/      $��Palatino Linotype)�50      $��Center=�51      $��Center=�52      $
��auto��53      �� 5>      -   5         ��Name$ RoadTypeBox��5>      $��45��60   $	��200��6<   $��Palatino Linotype)�6H   $��25(�6g    �� SelectedIndex$ 0��6u   $��Right=�6�   .@�5?      �� $��state��6#   �� 5@      $��regional��6#   �� 5A      $��areal��6#   �� 5B      $��local��6#   5C      5D      ]� 5E      $��0,130,-0.2,185q�6   .+�5F      �� $
��Left=�5G      $��Road length :��5H      $��30(�5I      $��Palatino Linotype)�5J      $��Center=�5K      $��Center=�5L      $
��auto��5M      �� 5N      -   5        $��
RoadLength��5P      $
��Left=�5O      #��[ 5Q      $
  Auto=�5R       . $
 Wrap=�5T      $��Palatino Linotype)�5U      $��30(�5V      $��55��5W      $��100, 0, 2, 0q�5X      5Z      ]� 5[      $��0,195,-0.2,120q�6   .+�5\      �� $
��Left=�5]      $��Amount road lines :��5^      $��30(�5_      $��Palatino Linotype)�5`      $��Center=�5a      $��Center=�5b      $
��auto��5c      �� 5d      -   5        $��AmountRoadLines��5f      $
��Left=�5e      #��[ 5g      $
  Auto=�5h       . $
 Wrap=�5j      $��Palatino Linotype)�5k      $��30(�5l      $��55��5m      $��12, 0, 0, 0q�5n      5o      ]� 5p      $��0,260,-0.2,55q�6   .+�5q      �� $
��Left=�5r      $��Crosswalk availability :��5s      $��30(�5t      $��Palatino Linotype)�5u      $��Center=�5v      $��Center=�5w      $
��auto��5x      �� 5y      -   5        $ BanquetteBox��5y      $��45��61   $	��200��6=   $��Palatino Linotype)�6I   $��25(�6h   $ 0��6v   $��Right=�6�   .@�5z      �� $��unavailable��6#   �� 5{      $��	available��6#   5|      5}      ]� 5~      $��0,325,-0.2,0q�6   .+�5      �� $
��Left=�5�      $��Separator availability :��5�      $��30(�5�      $��Palatino Linotype)�5�      $��Center=�5�      $��Center=�5�      $
��auto��5�      �� 5�      -   5        $ SeparatorBox��5�      $��45��61   $	��200��6=   $��Palatino Linotype)�6I   $��25(�6h   $ 0��6v   $��Right=�6�   .@�5�      �� $��unavailable��6#   �� 5�      $��	available��6#   5�      5�      5�      5�      5�      