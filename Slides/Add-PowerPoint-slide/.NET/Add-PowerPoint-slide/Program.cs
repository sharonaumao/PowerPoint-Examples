﻿using Syncfusion.Presentation;

//Loads or open an PowerPoint Presentation
using IPresentation pptxDoc = Presentation.Create();
//Adds a slide to the PowerPoint presentation
ISlide slide = pptxDoc.Slides.Add();
using FileStream outputStream = new(Path.GetFullPath(@"../../../Result.pptx"), FileMode.Create, FileAccess.ReadWrite);
pptxDoc.Save(outputStream);
