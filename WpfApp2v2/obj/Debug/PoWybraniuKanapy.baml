   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.PoWybraniuKanapy   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  PoWybraniuKanapy��5   	   $��393.115��6"   $��740.068��63   .��5	      � .+�5
   
   �� -   5         ��Name$ NazwaModeluBox��5
      $
��Left=�6,   $��43��6G   $��
218,45,0,0q�6S    �� TextWrapping$
 Wrap=�6g   $��TextBox��6{   $	��Top=�6�   $	��170��6�   �� 5   
   $��Nazwa modelu��6   $
��Left=�6'   $��29��6B   $��
218,10,0,0q�6N   $	��Top=�6b   $	��170��6z   �� 5   
   -   5        $ CenaBox��5      $
��Left=�6%   $��43��6@   $��
393,45,0,0q�6L   $
 Wrap=�6`   $��TextBox��6t   $	��Top=�6�   $	��127��6�   �� 5   
   $
��Cena��6   $
��Left=�6   $��29��6:   $��
393,12,0,0q�6F   $	��Top=�6Z   $	��127��6r   �� 5   
   -   5        $ WysokoscBox��5      $
��Left=�6)   $��42��6D   $��
525,46,0,0q�6P   $
 Wrap=�6d   $��TextBox��6x   $	��Top=�6�   $	��127��6�   �� 5   
   $��Wysokosc��6   $
��Left=�6#   $��29��6>   $��
536,12,0,0q�6J   $	��Top=�6^   $	��116��6v   �� 5   
   $��	Szerokosc��6   $
��Left=�6$   $��29��6?   $��
31,118,0,0q�6K   $	��Top=�6_   $	��128��6w   �� 5   
   -   5        $ SzerokoscBox��5      $
��Left=�6+   $��30��6F   $��
31,173,0,0q�6R   $
 Wrap=�6f   $��TextBox��6z   $	��Top=�6�   $	��128��6�   �� 5   
   $��	Glebokosc��6   $
��Left=�6$   $��46��6?   $��179,117,0,0q�6K   $	��Top=�6`   $	��170��6x    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.698Q�6&   T� 5      5      5      �� 5   
   -   5        $ GlebokoscBox��5      $
��Left=�6*   $��40��6E   $��184,159,0,0q�6Q   $
 Wrap=�6f   $��TextBox��6z   $	��Top=�6�   $	��170��6�   �� 5   
   -   5         ��Name$ ComboTypKanapy��5      $
��Left=�6-   $��40��6H   $��370,159,0,0q�6T   $	��Top=�6i   $	��139��6�   �� 5   
   $��
Typ Kanapy��6   $
��Left=�6%   $��29��6@   $��381,118,0,0q�6L   $	��Top=�6a   $	��139��6y   �� 5   
   -   5        $ ComboBoxProducenci��5      $
��Left=�6/   $��40��6J   $��536,159,0,0q�6V   $	��Top=�6k   $	��133��6�   �� 5    
   $��	Producent��6   $
��Left=�6$   $��25��6?   $��559,122,0,0q�6K   $	��Top=�6`   $	��127��6x   �� 5!   
   -   5        $��Dodaj Do Asortymentu��5!      $
��Left=�60   $��38��6K   $��308,271,0,0q�6W   $	��Top=�6l   $	��170��6�   6�   �� 5"   
   -	   5        $ ComboBoxMaterialy��5"   q   $
��Left=�6   $��46��6.   $��	35,45,0,0q�6:   $	��Top=�6M   $	��166��6e   6q   �� 5#   
   $��Material��6   $
��Left=�6#   $��30��6>   $��35,0,0,0q�6J   $	��Top=�6\   $	��166��6t   �� 5$   
   -
   5        $��RozkladanaCheckBox��5$      $��
Rozkladana��60   $
��Left=�6E   $��20��6`   $��536,229,0,0q�6l   $	��Top=�6�   $	��134��6�   5&      5'      