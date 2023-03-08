# FloatingPointTextBox
A WPF text box control that behaves better when bound to a floating point property
(either `Single` or `Double`) and the binding defines a `StringFormat`.

On my first WPF project, I noticed a lot of challenges users had entering
floating point numbers into the standard `TextBox` control. So we developed a
subclass that manages the behavior better. See Article-FloatingPointTextBox.pdf
for more information.

## Dependencies
If you are pulling this control into your own project, make sure you also grab
the extension method (`string.HasOnlyOne(char)`) defined in ExtensionMethods.cs.

## Example Program
In the Main directory is a small Example program that uses both a `TextBox` and
a `FloatingPointTextBox` control so you can examine the differences in their
behavior.

If you change the `StringFormat` on one of these controls' bindings in MainWindow.xaml,
be sure to change the other one to the same value.
