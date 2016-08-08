/** Authors & Student Number:
    Fei Wang 200278460
    Siqian Yu 200286902
    Date Modified: 08-08-2016
    File Description: This is the song model. 
    **/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace COMP2007_S2016_Lesson12C.Models
{
    public class Song
    {
        public virtual int SongId { get; set; }
        public virtual string SongName { get; set; }
        public virtual string SongDuration { get; set; }
    }
}