class Hinhtron
{
    float radius;
    public Hinhtron()
    {
        Console.WriteLine("Khong co ban kinh!");
    }
    public Hinhtron(float radius)
    {
        this.radius = radius;
    }
    public float AreaHinhtron()
    {
        float localradius = (3.14f)*radius*radius;
        return localradius;
    }
    public float Chuvihinhtron()
    {
        return 3.14f*2*radius;
    }
}