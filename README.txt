Code Explaination:
------------------

The code flow starts from startForm.
It asks for input to K (no of workers) and on press go button, control shifts from startForm to Form1.
It takes K in the constructor.
First, it draws 1000 circles on a full screen window. Then, depending
on the no of workers entered (K), it starts filling those circles one by one with the speed of 200/K time per circle.
Larger the K is (more workers available), faster the circles will be painted.
DrawEllipse method from graphics library is used to
draw circles with pen, and FillEllipse method is later on used to fill those circles.
Circle class holds the position (x,y) and diameter of the circle instance.
When a circle is drawn, a Circle object with x,y,diameter is created and added to the 
List<Circle>circles. While filling, each circle data is fetched from this list.