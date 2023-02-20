using Canva;
using System;
using System.Drawing;

public class Space
{
	private float spread, speed;
	Random rand;
	float[] x, y, z;

	public Space(int stars, float spread, float speed)
	{
		this.speed= speed;
		this.spread= spread;

		x = new float[stars];
		y = new float[stars];
		z = new float[stars];

		rand= new Random();

		for (int i = 0; i < stars; i++)
		{
			Init(i);
		}
	}

	public void Init(int index)
	{
		x[index] = 2 * ((float)rand.NextDouble() - 0.5f) * spread;
		y[index] = 2 * ((float)rand.NextDouble() - 0.5f) * spread;
		z[index] = ((float)rand.NextDouble() + 0.00001f) * spread;
    }

	public void Render(Canvas target, float delta)
	{
		target.Clear();

		float hWidth = target.Width/2f;
		float hHeight = target.Height /2f;

		for (int i = 0; i < x.Length; i++)
		{
			z[i] -= delta * speed;
			if (z[i]<=0)
				Init(i);
			int xPos = (int)(x[i]*hWidth+hWidth);
			int	yPos = (int)(y[i]*hHeight+hHeight);

			if (xPos < 0 || xPos >= target.Width || yPos < 0 || yPos >= target.Height)
			{
				Init(i);
			}
			else
				target.PutPixel(xPos, yPos, Color.White);
		}
	}
}
