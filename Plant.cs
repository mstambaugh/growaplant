namespace Planties
{
  class Plant
  {
    private int _water;
    private int _fertilizer;
    private int _sunshine;

    public Plant(int water, int fertilizer, int sunshine)
    {
      _water = water;
      _fertilizer = fertilizer;
      _sunshine = sunshine;
    }
    public int GetWater()
    {
      return _water;
    }
    public int GetFertilizer()
    {
      return _fertilizer;
    }
    public int GetSunshine()
    {
      return _sunshine;
    }
    public bool IsAlive()
    {
      return _water > 0 && _fertilizer > 0 && _sunshine > 0;
    }
    public void Water()
    {
      _water = _water + 3;
      _fertilizer = _fertilizer - 1;
      _sunshine = _sunshine - 1;
    }
    public void Fertilize()
    {
      _fertilizer = _fertilizer + 2;
      _water = _water - 1;
      _sunshine = _sunshine - 1;
    }
    public void Solarize()
    {
      _sunshine = _sunshine + 3;
      _fertilizer = _fertilizer -1;
      _water = _water - 4;
    }
  }
}