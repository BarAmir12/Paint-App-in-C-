﻿using System;
using System.Drawing;
using System.IO;

namespace Cyotek.Windows.Forms
{
  
  public class AdobeColorTablePaletteSerializer : PaletteSerializer
  {
    #region Properties

    /// <summary>
    /// Gets the default extension for files generated with this palette format.
    /// </summary>
    /// <value>The default extension for files generated with this palette format.</value>
    public override string DefaultExtension
    {
      get { return "act"; }
    }

    /// <summary>
    /// Gets the maximum number of colors supported by this format.
    /// </summary>
    /// <value>
    /// The maximum value number of colors supported by this format.
    /// </value>
    public override int Maximum
    {
      get { return 256; }
    }

    /// <summary>
    /// Gets the minimum numbers of colors supported by this format.
    /// </summary>
    /// <value>
    /// The minimum number of colors supported by this format.
    /// </value>
    public override int Minimum
    {
      get { return 1; }
    }

    /// <summary>
    /// Gets a descriptive name of the palette format
    /// </summary>
    /// <value>The descriptive name of the palette format.</value>
    public override string Name
    {
      get { return "Adobe Color Table"; }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Determines whether this instance can read palette from data the specified stream.
    /// </summary>
    /// <param name="stream">The stream.</param>
    /// <returns><c>true</c> if this instance can read palette data from the specified stream; otherwise, <c>false</c>.</returns>
    public override bool CanReadFrom(Stream stream)
    {
      bool result;

      if (stream == null)
      {
        throw new ArgumentNullException(nameof(stream));
      }

      try
      {
        result = stream.Length == 768 || stream.Length == 772;
      }
      catch
      {
        result = false;
      }

      return result;
    }

    /// <summary>
    /// Deserializes the <see cref="ColorCollection" /> contained by the specified <see cref="Stream" />.
    /// </summary>
    /// <param name="stream">The <see cref="Stream" /> that contains the palette to deserialize.</param>
    /// <returns>The <see cref="ColorCollection" /> being deserialized.</returns>
    public override ColorCollection Deserialize(Stream stream)
    {
      ColorCollection results;
      int count;

      if (stream == null)
      {
        throw new ArgumentNullException(nameof(stream));
      }

      results = new ColorCollection();

      count = (int)(stream.Length / 3);

      for (int i = 0; i < count; i++)
      {
        int r;
        int g;
        int b;

        r = stream.ReadByte();
        g = stream.ReadByte();
        b = stream.ReadByte();

        results.Add(Color.FromArgb(r, g, b));
      }

      if (count == 257)
      {
        int realCount;

        // undocumented on the spec page, but when poking around
        // the Optimized Colors preset files of CS2, I found that
        // four extra bytes were added to some files. The second of
        // these extra bytes specified how many colours are
        // really in use (anything else is just padding)

        realCount = results[256].G;

        while (results.Count > realCount)
        {
          results.RemoveAt(realCount);
        }
      }

      return results;
    }

    /// <summary>
    /// Serializes the specified <see cref="ColorCollection" /> and writes the palette to a file using the specified <see cref="Stream" />.
    /// </summary>
    /// <param name="stream">The <see cref="Stream" /> used to write the palette.</param>
    /// <param name="palette">The <see cref="ColorCollection" /> to serialize.</param>
    public override void Serialize(Stream stream, ColorCollection palette)
    {
      int count;

      if (stream == null)
      {
        throw new ArgumentNullException(nameof(stream));
      }

      if (palette == null)
      {
        throw new ArgumentNullException(nameof(palette));
      }

      count = palette.Count;

      if (count > 256)
      {
        throw new InvalidDataException("A maximum of 255 colors are supported by this format.");
      }

      foreach (Color color in palette)
      {
        stream.WriteByte(color.R);
        stream.WriteByte(color.G);
        stream.WriteByte(color.B);
      }

      if (count < 256)
      {
        // add padding
        for (int i = count; i < 256; i++)
        {
          stream.WriteByte(0);
          stream.WriteByte(0);
          stream.WriteByte(0);
        }

        // add an extra four bytes which seem to describe the number
        // of used colours
        stream.WriteByte(0);
        stream.WriteByte((byte)count);
        stream.WriteByte(0);
        stream.WriteByte(0);
      }

      stream.Flush();
    }

    #endregion
  }
}
