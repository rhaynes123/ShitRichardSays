using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShitRichardSays.Data
{
    public class RecordingService: ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public RecordingService(ApplicationDbContext _context)
        {
            this._context = _context;
        }
        public Task<List<Recording>> GetAllRecordings()
        {
            var Recordinglist = _context.GetRecordings();
            return Recordinglist;
        }
    }
}
