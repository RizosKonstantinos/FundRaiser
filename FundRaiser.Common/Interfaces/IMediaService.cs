﻿using FundRaiser.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser.Common.Interfaces
{
    public interface IMediaService
    {
        Task<Media> Create(Media _media);
        Task<Media> Update(int projectId, Media _media);
        Task<bool> Delete(int mediaId);
        Task<List<Media>> GetMedia(int projectId);
    }
}
