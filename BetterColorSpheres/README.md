# UML Diagram

```mermaid

classDiagram
    class Color {
        - byte Red
        - byte Green
        - byte Blue
        - byte Alpha
        + Color(byte red, byte green, byte blue, byte alpha = 255)
        + byte GetRed()
        + byte GetGreen()
        + byte GetBlue()
        + byte GetAlpha()
        + byte GetGrey()
    }

    class Sphere {
        - Color Color
        - float Radius
        - int TimesThrown
        + Sphere(Color color, float radius)
        + void Throw()
        + void Pop()
        + Color GetColor()
        + float GetRadius()
        + int GetTimesThrown()
    }

    class Program {
        + Main()
    }

    Color <|-- Sphere
    Program --> Sphere
