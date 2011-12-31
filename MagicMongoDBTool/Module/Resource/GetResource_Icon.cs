﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace MagicMongoDBTool.Module
{
    public partial class GetResource
    {
        public static Icon GetIcon(IconType theIcon)
        {
            Icon micon = null;

            switch (theIcon)
            {
                case IconType.Yes:
                    micon = MagicMongoDBTool.Properties.Resources.ok;
                    break;
                case IconType.No:
                    micon = MagicMongoDBTool.Properties.Resources.DELETE;
                    break;
            }
            return micon;
        }
        public static Image GetImage(ImageType theImage)
        {
            Image micon = null;
            switch (theImage)
            {
                case ImageType.Blank:
                    micon = MagicMongoDBTool.Properties.Resources.Blank;
                    break;
                case ImageType.AccessDB:
                    micon = MagicMongoDBTool.Properties.Resources.AccessDB;
                    break;
                case ImageType.Option:
                    micon = MagicMongoDBTool.Properties.Resources.Option;
                    break;
                case ImageType.Refresh:
                    micon = MagicMongoDBTool.Properties.Resources.Refresh;
                    break;
                case ImageType.NextPage:
                    micon = MagicMongoDBTool.Properties.Resources.NextPage;
                    break;
                case ImageType.PrePage:
                    //水平翻转
                    micon = MagicMongoDBTool.Properties.Resources.NextPage;
                    micon.RotateFlip(RotateFlipType.Rotate180FlipY);
                    break;
                case ImageType.LastPage:
                    micon = MagicMongoDBTool.Properties.Resources.LastPage;
                    break;
                case ImageType.FirstPage:
                    //水平翻转
                    micon = MagicMongoDBTool.Properties.Resources.LastPage;
                    micon.RotateFlip(RotateFlipType.Rotate180FlipY);
                    break;
                case ImageType.Query:
                    micon = MagicMongoDBTool.Properties.Resources.Query;
                    break;
                case ImageType.Filter:
                    micon = MagicMongoDBTool.Properties.Resources.Filter;
                    break;
                case ImageType.WebServer:
                    micon = MagicMongoDBTool.Properties.Resources.WebServer;
                    break;
                case ImageType.Database:
                    micon = MagicMongoDBTool.Properties.Resources.Database;
                    break;
                case ImageType.Collection:
                    micon = MagicMongoDBTool.Properties.Resources.Collection;
                    break;
                case ImageType.Keys:
                    micon = MagicMongoDBTool.Properties.Resources.Keys;
                    break;
                case ImageType.DBKey:
                    micon = MagicMongoDBTool.Properties.Resources.DBkey;
                    break;
                case ImageType.Document:
                    micon = MagicMongoDBTool.Properties.Resources.Document;
                    break;
                case ImageType.Smile:
                    micon = MagicMongoDBTool.Properties.Resources.Smile;
                    break;


                default:
                    break;
            }
            return micon;
        }
    }
    public enum IconType
    {
        Yes,
        No
    }
    public enum ImageType
    {
        Blank,
        /// <summary>
        /// Access数据库
        /// </summary>
        AccessDB,
        /// <summary>
        /// 选项
        /// </summary>
        NextPage,
        PrePage,
        FirstPage,
        LastPage,
        Query,
        Filter,

        Option,
        /// <summary>
        /// 刷新
        /// </summary>
        Refresh,

        WebServer,
        Database,
        Collection,

        Keys,
        DBKey,
        Document,

        Smile

    }
}