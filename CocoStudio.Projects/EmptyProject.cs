﻿// Decompiled with JetBrains decompiler
// Type: CocoStudio.Projects.EmptyProject
// Assembly: CocoStudio.Projects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DCF182CC-57DB-4DD6-AF38-C89A798411CC
// Assembly location: C:\Program Files (x86)\Cocos\Cocos Studio 2\CocoStudio.Projects.dll

using MonoDevelop.Core;

namespace CocoStudio.Projects
{
  public class EmptyProject : Project
  {
    public EmptyProject(string fileName)
    {
      this.FileName = new FilePath(fileName);
    }
  }
}
