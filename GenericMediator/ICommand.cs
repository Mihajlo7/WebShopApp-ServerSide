﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GenericMediator
{
    public interface ICommand<out TRes> : IRequest<TRes>
    {
    }
}
