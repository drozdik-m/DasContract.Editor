﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;

namespace Bonsai.RazorComponents.MaterialBootstrap.Components.CCard.Groups
{
    public partial class CardColumns: LoadableComponent
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}