   M S B A M L   `   `   `  ����  HamroClass1    HamroClass1.AddCourse   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Add New Course��5   	   $	��560��6    $	��420��6-    � 
ResizeMode$ NoResize=�5   	   .��5   
   � ��5   
   �� 5       �� ImageSource$ Images/blurBackground.jpg��6    �� Opacity$	 0.8Q�6A    j� Stretch$ UniformToFill=�6O   .+�5   
   �� $��50��6   $	��Top=�6   $��20(�64   $��Center=�6B   $	��170��6_   .��6l   Add a new Course6~   �� 5   
   -   5         ��Name$ label��5      $��Course Code��6   $
��Left=�65   $��35��6P   $��	10,66,0,0q�6\   $	��Top=�6o   $	��142��6�   �� 5   
   -   5        $ 
label_Copy��5      $��Course Name��6$   $
��Left=�6:   $��35��6U   $��
10,106,0,0q�6a   $	��Top=�6u   $	��142��6�   �� 5   
   -   5        $ label_Copy1��5      $��Faculty��6%   $
��Left=�67   $��36��6R   $��
10,226,0,0q�6^   $	��Top=�6r   $	��142��6�   �� 5   
   -   5        $ label_Copy2��5      $��Associated Teachers��6%   $
��Left=�6C   $��34��6^   $��
10,300,0,0q�6j   $	��Top=�6~   $	��142��6�   �� 5   
   -   5        $ label_Copy3��5      $��Year/Semester��6%   $
��Left=�6=   $��35��6X   $��
10,146,0,0q�6d   $	��Top=�6x   $	��142��6�   �� 5   
   -   5        $ label_Copy4��5      $��Course Credit��6%   $
��Left=�6=   $��35��6X   $��
10,186,0,0q�6d   $	��Top=�6x   $	��142��6�   �� 5   
   -   5         ��Name$ courseCodetextBox��5      $	��4 8q�6.   $
��Left=�6<   $��35��6W   $��
177,66,0,0q�6c    �� TextWrapping$
 Wrap=�6w   $�� ��6�   $	��Top=�6�   $	��214��6�    �� CharacterCasing$ Upper=�6�   	 �� 	MaxLength$	 7��6�   ��6�   Z� 6�   �� 5   
   -   5        $ 
courseName��5      $	��4 8q�6&   $
��Left=�64   $��35��6O   $��177,106,0,0q�6[   $
 Wrap=�6p   $�� ��6�   $	��Top=�6�   $	��214��6�   ��6�   Z� �� 5   
   -	   5        
 ��Name$
 yearSemesterChooser��5      $	��4 8q�60   $
��Left=�6>   $��35��6Y   $��177,146,0,0q�6e   $	��Top=�6z   $	��214��6�   5   3   �� 5   
   -
   5        $ courseCredit��5      $	��4 8q�6(   $
��Left=�66   $��35��6Q   $��177,186,0,0q�6]   $
 Wrap=�6r   $�� ��6�   $	��Top=�6�   $	��214��6�   ��6�   Z� �� 5   
   -   5        $
 facultyChooser��5      $	��4 8q�6+   $
��Left=�69   $��36��6T   $��177,226,0,0q�6`   $	��Top=�6u   $	��174��6�   ��5   \   Z� �� 5   
   $	��Top=�6   $
��Left=�6)   $��356,226,0,0q�6D   $��35��6o   $��24(�6z   $��+��6�   $��36��6�   $��Stencil)�6�    J� RenderTransformOrigin$ 2.729,1.417&�6�   ��6Y   Z� 6�   �� 5   
   -   5        $
 teacherChooser��5      $	��4 8q�6+   $
��Left=�6O   $��34��6j   $��177,300,0,0q�6v   $	��Top=�6�   $	��174��6�    �� 
IsEditable . ��69   Z� 5    \   �� 5!   
   $	��Top=�6   $
��Left=�6)   $��356,300,0,0q�6D   $��35��6o   $��24(�6z   $��+��6�   $��34��6�   $
��Bold"�6�   $��Stencil)�6�   ��6Y   Z� 6�   �� 5#   
   -   5         ��Name$ addCourseButton��5#      $	��Top=�6*   $
��Left=�6B   $��50��6]   $��177,459,0,0q�6i   $	��214��6�   ��6~   Z� .��6�   
Add Course6�   �� 5$   
   -   5        $ cancelButton��5$      $	��Top=�6'   $
��Left=�6?   $��50��6Z   $��
10,459,0,0q�6f   $	��162��6�   $��Cancel��6�   ��6z   Z� 6�   5&      5'      