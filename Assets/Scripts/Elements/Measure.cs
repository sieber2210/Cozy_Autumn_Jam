using System;

// a Measure is the element and how many instances of it are needed
[Serializable]
public class Measure
{
    public Element element;
    public int amount;

    public Measure(Element element, int amount) {
        this.element = element;
        this.amount = amount;
    }

    // needed to compare selected ingredients against recipes
    public override bool Equals(object obj)
    {
        if (obj is Measure)
        {
            Measure other = obj as Measure;
            if (this.element == other.element && this.amount == other.amount) {
                return true;
            }
        }
        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
