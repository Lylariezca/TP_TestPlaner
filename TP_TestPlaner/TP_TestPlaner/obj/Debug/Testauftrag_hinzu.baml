   M S B A M L   `   `   `  ����H  DTP_TestPlaner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TP_TestPlanerTP_TestPlaner  5   	   %    TP_TestPlaner.Testauftrag_hinzu   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:TP_TestPlaner     5   	     � Title$  Testauftrag hinzufügen��5   	   $	��507��6(   $	��639��65   .��5	      � .+�5
   
   �� -   5         ��Name$ label��5
      $��Titel: ��6   $
��Left=�61   $��	10,14,0,0q�6L   $	��Top=�6_   �� 5   
   -   5        $ label1��5      $��	Projekt: ��6    $
��Left=�64   $��	10,79,0,0q�6O   $	��Top=�6b   �� 5   
   -   5        $ label2��5      $��Version des Projektes: ��6    $
��Left=�6B   $��
10,110,0,0q�6]   $	��Top=�6q   �� 5   
   -   5        $ label3��5      $��Priorität: ��6    $
��Left=�66   $��
10,141,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $ label4��5      $��Art des Tests: ��6    $
��Left=�6:   $��
10,172,0,0q�6U   $	��Top=�6i   �� 5   
   -   5        $ label5��5      $��Start: ��6    $
��Left=�62   $��
10,203,0,0q�6M   $	��Top=�6a   �� 5   
   -   5        $ label6��5      $��Ende: ��6    $
��Left=�61   $��
10,234,0,0q�6L   $	��Top=�6`   �� 5   
   -   5        $ label7��5      $��Termin/ Deadline: ��6    $
��Left=�6=   $��
10,265,0,0q�6X   $	��Top=�6l   �� 5   
   -	   5        $ label8��5      $��Status: ��6    $
��Left=�63   $��
10,296,0,0q�6N   $	��Top=�6b   �� 5   
   -
   5        $ label9��5      $��Risiko-Level: ��6    $
��Left=�69   $��
10,327,0,0q�6T   $	��Top=�6h   �� 5   
   -   5        $ label10��5      $��Testauftrag-Ersteller:��6!   $
��Left=�6B   $��
10,358,0,0q�6]   $	��Top=�6q   �� 5   
   -   5         ��Name$ button��5      $��	Abbrechen��6!   $
��Left=�65   $��
10,435,0,0q�6P   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5        $ button1��5      $��	Speichern��6"   $
��Left=�66   $��530,435,0,0q�6Q   $	��Top=�6f   $��75��6~   �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $��23��6>   $��
250,17,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��355��6�   �� 5   
   -   5        $ textBox1��5      $
��Left=�6$   $��23��6?   $��
250,79,0,0q�6K   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��355��6�   �� 5   
   -   5        $ textBox2��5      $
��Left=�6$   $��23��6?   $��250,110,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��355��6�   �� 5   
   -   5         ��Name$ comboBox��5      $
��Left=�6%   $��250,141,0,0q�6@   $	��Top=�6U   $	��355��6m   .@�5      �� $	��Low��6   �� 5      $��Medium��6   �� 5      $
��High��6   5      �� 5   
   -   5        $ 	comboBox1��5      $
��Left=�6&   $��250,172,0,0q�6A   $	��Top=�6V   $	��355��6n   .@�5       �� $��
Smoke-Test��6   �� 5!      $��System-Test��6   �� 5"      $��	Last-Test��6   5#      (  "System.Windows.Controls.DatePicker  5$   
   $
��Left=�6   $��250,203,0,0q�60   $	��Top=�6E   $	��355��6]     5%   
   $
��Left=�6   $��250,234,0,0q�60   $	��Top=�6E   $	��355��6]     5&   
   $
��Left=�6   $��250,265,0,0q�60   $	��Top=�6E   $	��355��6]   �� 5'   
   -   5        $ 	comboBox2��5'      $
��Left=�6&   $��250,296,0,0q�6A   $	��Top=�6V   $	��355��6n   .@�5(      �� $��Erstellt��6   �� 5)      $��
Zugewiesen��6   �� 5*      $��In Durchführung��6   �� 5+      $��	Blockiert��6   �� 5,      $��Getestet��6   5-      �� 5.   
   -   5        $ 	comboBox3��5.      $
��Left=�6&   $��250,327,0,0q�6A   $	��Top=�6V   $	��355��6n   �� 5/   
   -   5        $ textBox3��5/      $
��Left=�6$   $��23��6?   $��250,360,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��355��6�   �� 50   
   -   5        $ label11��50      $��Tester: ��6!   $
��Left=�64   $��
10,389,0,0q�6O   $	��Top=�6c   �� 51   
   -   5        $ 	comboBox4��51      $
��Left=�6&   $��250,393,0,0q�6A   $	��Top=�6V   $	��355��6n   �� 52   
   -   5        $ label12��52      $��Gemini-ID: ��6!   $
��Left=�67   $��	10,45,0,0q�6R   $	��Top=�6e   �� 53   
   -   5        $ textBox4��53      $
��Left=�6$   $��23��6?   $��
250,48,0,0q�6K   $
 Wrap=�6_   $��TextBox��6s   $	��Top=�6�   $	��355��6�   55      56      