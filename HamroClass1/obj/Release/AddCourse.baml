   M S B A M L   `   `   `  ����   HamroClass1    HamroClass1.AddCourse   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Add New Course��$	��560��$	��420�� � 
ResizeMode$ NoResize=�.��� ����  �� ImageSource$ Images/blurBackground.jpg�� �� Opacity$	 0.8Q� j� Stretch$ UniformToFill=�.+��� $��50��$	��Top=�$��20(�$��Center=�$	��170��.��Add a new Course�� -    ��Name$ label��$��Course Code��$
��Left=�$��35��$��	10,66,0,0q�$	��Top=�$	��142���� -   $ 
label_Copy��$��Course Name��$
��Left=�$��35��$��
10,106,0,0q�$	��Top=�$	��142���� -   $ label_Copy1��$��Faculty��$
��Left=�$��36��$��
10,226,0,0q�$	��Top=�$	��142���� -   $ label_Copy2��$��Associated Teachers��$
��Left=�$��34��$��
10,300,0,0q�$	��Top=�$	��142���� -   $ label_Copy3��$��Year/Semester��$
��Left=�$��35��$��
10,146,0,0q�$	��Top=�$	��142���� -   $ label_Copy4��$��Course Credit��$
��Left=�$��35��$��
10,186,0,0q�$	��Top=�$	��142���� -    ��Name$ courseCodetextBox��$	��4 8q�$
��Left=�$��35��$��
177,66,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��214�� �� CharacterCasing$ Upper=�	 �� 	MaxLength$	 7����Z� �� -   $ 
courseName��$	��4 8q�$
��Left=�$��35��$��177,106,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��214����Z� �� -	   
 ��Name$
 yearSemesterChooser��$	��4 8q�$
��Left=�$��35��$��177,146,0,0q�$	��Top=�$	��214���� -
   $ courseCredit��$	��4 8q�$
��Left=�$��35��$��177,186,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��214����Z� �� -   $
 facultyChooser��$	��4 8q�$
��Left=�$��36��$��177,226,0,0q�$	��Top=�$	��174����Z� �� $	��Top=�$
��Left=�$��356,226,0,0q�$��35��$��24(�$��+��$��36��$��Stencil)� J� RenderTransformOrigin$ 2.729,1.417&���Z� �� -   $
 teacherChooser��$	��4 8q�$
��Left=�$��34��$��177,300,0,0q�$	��Top=�$	��174�� �� 
IsEditable . ��Z� �� $	��Top=�$
��Left=�$��356,300,0,0q�$��35��$��24(�$��+��$��34��$
��Bold"�$��Stencil)���Z� �� -    ��Name$ addCourseButton��$	��Top=�$
��Left=�$��50��$��177,459,0,0q�$	��214����Z� .��
Add Course�� -   $ cancelButton��$	��Top=�$
��Left=�$��50��$��
10,459,0,0q�$	��162��$��Cancel����Z� 