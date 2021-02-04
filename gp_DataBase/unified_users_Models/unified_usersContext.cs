using System;
using gp_DataBase.DbExtend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace gp_DataBase.unified_users_Models
{
    public partial class unified_usersContext : EFCoreAllContext
    {
        public unified_usersContext(string conn) : base(conn)
        {
        }

        public unified_usersContext(DbContextOptions<unified_usersContext> options)
            : base(options.ToString())
        {
        }

        public virtual DbSet<Efmigrationshistory> Efmigrationshistory { get; set; }
        public virtual DbSet<NtAddArea> NtAddArea { get; set; }
        public virtual DbSet<NtAddress> NtAddress { get; set; }
        public virtual DbSet<NtAddressCopy> NtAddressCopy { get; set; }
        public virtual DbSet<NtAlbum> NtAlbum { get; set; }
        public virtual DbSet<NtCdnAd> NtCdnAd { get; set; }
        public virtual DbSet<NtCdnCmsid> NtCdnCmsid { get; set; }
        public virtual DbSet<NtCertPrinting> NtCertPrinting { get; set; }
        public virtual DbSet<NtCloudCollege> NtCloudCollege { get; set; }
        public virtual DbSet<NtCollegeApply> NtCollegeApply { get; set; }
        public virtual DbSet<NtCourse> NtCourse { get; set; }
        public virtual DbSet<NtCourseLabel> NtCourseLabel { get; set; }
        public virtual DbSet<NtCourseTeacher> NtCourseTeacher { get; set; }
        public virtual DbSet<NtCourseware> NtCourseware { get; set; }
        public virtual DbSet<NtCoursewareFile> NtCoursewareFile { get; set; }
        public virtual DbSet<NtFriend> NtFriend { get; set; }
        public virtual DbSet<NtInvoiceRecords> NtInvoiceRecords { get; set; }
        public virtual DbSet<NtKeywordFilter> NtKeywordFilter { get; set; }
        public virtual DbSet<NtLive> NtLive { get; set; }
        public virtual DbSet<NtLivestudent> NtLivestudent { get; set; }
        public virtual DbSet<NtPrivateMessage> NtPrivateMessage { get; set; }
        public virtual DbSet<NtProjectmanage> NtProjectmanage { get; set; }
        public virtual DbSet<NtProjectmanageFocus> NtProjectmanageFocus { get; set; }
        public virtual DbSet<NtProjectmanageOrders> NtProjectmanageOrders { get; set; }
        public virtual DbSet<NtRegisterAppeal> NtRegisterAppeal { get; set; }
        public virtual DbSet<NtResourceFile> NtResourceFile { get; set; }
        public virtual DbSet<NtStudentProject> NtStudentProject { get; set; }
        public virtual DbSet<NtStudentResourceFile> NtStudentResourceFile { get; set; }
        public virtual DbSet<NtTeProjectmanager> NtTeProjectmanager { get; set; }
        public virtual DbSet<NtTeacher> NtTeacher { get; set; }
        public virtual DbSet<NtTransactions> NtTransactions { get; set; }
        public virtual DbSet<NtUsers> NtUsers { get; set; }
        public virtual DbSet<NtUsersJx> NtUsersJx { get; set; }
        public virtual DbSet<NtWeikeResource> NtWeikeResource { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseMySql("server=10.1.140.119;database=unified_users;uid=gpjh;pwd=123456", x => x.ServerVersion("5.6.21-mysql"));
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId)
                    .HasColumnType("varchar(95)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtAddArea>(entity =>
            {
                entity.ToTable("nt_add_area");

                entity.HasIndex(e => new { e.Type, e.Id })
                    .HasName("bytype");

                entity.HasIndex(e => new { e.Type, e.Province, e.Id })
                    .HasName("getbytype");

                entity.HasIndex(e => new { e.Province, e.Districtcounty, e.Workshop, e.Type })
                    .HasName("ProvinceDistWorkShopType");

                entity.HasIndex(e => new { e.Type, e.Discipline, e.Districtcounty, e.Workshop })
                    .HasName("ProvinceDistWorkShopType1");

                entity.HasIndex(e => new { e.Type, e.Science, e.StudySection, e.Districtcounty, e.Workshop })
                    .HasName("getbytype1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActivitiesCount)
                    .HasColumnName("activitiesCount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Answers)
                    .HasColumnName("ANSWERS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BigImg)
                    .HasColumnName("big_img")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Browsecount)
                    .HasColumnName("browsecount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClickCount)
                    .HasColumnName("CLICK_COUNT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Discipline)
                    .HasColumnName("DISCIPLINE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("DISTRICTCOUNTY")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.FansCount)
                    .HasColumnName("fansCount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Gonggao)
                    .HasColumnName("GONGGAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Grade)
                    .HasColumnName("GRADE")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupCount)
                    .HasColumnName("groupCount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HeadName)
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HeadPhone)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HeadTitle)
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Jianbao)
                    .HasColumnName("JIANBAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MembersCount)
                    .HasColumnName("membersCount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nickname)
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Onlinetime)
                    .HasColumnName("ONLINETIME")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("PARENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PgHomeworks)
                    .HasColumnName("PG_HOMEWORKS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Province)
                    .HasColumnName("PROVINCE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ProvinceId)
                    .HasColumnName("PROVINCE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.School)
                    .HasColumnName("SCHOOL")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Science)
                    .HasColumnName("SCIENCE")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.SmallImg)
                    .HasColumnName("small_img")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StudentCount)
                    .HasColumnName("STUDENT_COUNT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StudySection)
                    .HasColumnName("STUDY_SECTION")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学段")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TargetContent)
                    .HasColumnName("targetContent")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TjComments)
                    .HasColumnName("TJ_COMMENTS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TjCommentsId)
                    .HasColumnName("TJ_COMMENTS_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TjHomeworks)
                    .HasColumnName("TJ_HOMEWORKS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TjHomeworksId)
                    .HasColumnName("TJ_HOMEWORKS_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TjTopics)
                    .HasColumnName("TJ_TOPICS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TrainingTarget)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WorkShopQq)
                    .HasColumnName("WorkShop_QQ")
                    .HasColumnType("varchar(20)")
                    .HasComment("工作坊QQ群")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.WorkshopCount)
                    .HasColumnName("workshopCount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkshopLeaderCount)
                    .HasColumnName("workshopLeaderCount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Xian)
                    .HasColumnName("xian")
                    .HasColumnType("varchar(11)")
                    .HasComment("县，是原区县下一级（暂时是河北专用）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtAddress>(entity =>
            {
                entity.ToTable("nt_address");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Grade)
                    .HasColumnName("GRADE")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnName("PARENT_ID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NtAddressCopy>(entity =>
            {
                entity.ToTable("nt_address_copy");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Grade)
                    .HasColumnName("GRADE")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnName("PARENT_ID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NtAlbum>(entity =>
            {
                entity.ToTable("nt_album");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlbumContent)
                    .HasColumnName("albumContent")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CoverUrl)
                    .HasColumnName("COVER_URL")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsApprovaled)
                    .HasColumnName("IS_APPROVALED")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsPublic)
                    .HasColumnName("IS_PUBLIC")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("MODIFY_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumberOfPhotos)
                    .HasColumnName("NUMBER_OF_PHOTOS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("Project_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.School)
                    .HasColumnName("SCHOOL")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsersId)
                    .HasColumnName("USERS_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtCdnAd>(entity =>
            {
                entity.ToTable("nt_cdn_ad");

                entity.HasIndex(e => new { e.CourseId, e.CoursewareId, e.Type })
                    .HasName("getCDNbyCourse");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AutoOffFlag)
                    .HasColumnName("AUTO_OFF_FLAG")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AutoOffTime)
                    .HasColumnName("AUTO_OFF_TIME")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Chk1)
                    .HasColumnName("CHK1")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Chk1TxtFlag)
                    .HasColumnName("CHK1_TXT_FLAG")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Chk2)
                    .HasColumnName("CHK2")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Chk2TxtFlag)
                    .HasColumnName("CHK2_TXT_FLAG")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Chk3)
                    .HasColumnName("CHK3")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Chk3TxtFlag)
                    .HasColumnName("CHK3_TXT_FLAG")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Chk4)
                    .HasColumnName("CHK4")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Chk4TxtFlag)
                    .HasColumnName("CHK4_TXT_FLAG")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CourseId)
                    .HasColumnName("COURSE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CoursewareId)
                    .HasColumnName("COURSEWARE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Downbutton)
                    .HasColumnName("DOWNBUTTON")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("LINK_URL")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rad1)
                    .HasColumnName("RAD1")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rad1TxtFlag)
                    .HasColumnName("RAD1_TXT_FLAG")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rad2)
                    .HasColumnName("RAD2")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rad2TxtFlag)
                    .HasColumnName("RAD2_TXT_FLAG")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rad3)
                    .HasColumnName("RAD3")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rad3TxtFlag)
                    .HasColumnName("RAD3_TXT_FLAG")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rad4)
                    .HasColumnName("RAD4")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rad4TxtFlag)
                    .HasColumnName("RAD4_TXT_FLAG")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResourceFileId)
                    .HasColumnName("RESOURCE_FILE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResourceFilePath)
                    .HasColumnName("RESOURCE_FILE_PATH")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShowBegin)
                    .HasColumnName("SHOW_BEGIN")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShowTime)
                    .HasColumnName("SHOW_TIME")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Upbutton)
                    .HasColumnName("UPBUTTON")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtCdnCmsid>(entity =>
            {
                entity.ToTable("nt_cdn_cmsid");

                entity.HasIndex(e => new { e.ResourceFileId, e.Id })
                    .HasName("get1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsSend)
                    .HasColumnName("IS_SEND")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ResourceFileId)
                    .HasColumnName("RESOURCE_FILE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SendTime)
                    .HasColumnName("SEND_TIME")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<NtCertPrinting>(entity =>
            {
                entity.ToTable("nt_cert_printing");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .HasComment("id");

                entity.Property(e => e.Cardnumber)
                    .HasColumnName("CARDNUMBER")
                    .HasColumnType("varchar(64)")
                    .HasComment("身份证号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CompletionCert)
                    .HasColumnName("Completion_Cert")
                    .HasColumnType("varchar(128)")
                    .HasComment("结业证书")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Discipline)
                    .HasColumnName("DISCIPLINE")
                    .HasColumnType("varchar(128)")
                    .HasComment("学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("DISTRICTCOUNTY")
                    .HasColumnType("varchar(128)")
                    .HasComment("区县")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExcellentAdminCert)
                    .HasColumnName("Excellent_Admin_Cert")
                    .HasColumnType("varchar(128)")
                    .HasComment("优秀管理员证书")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExcellentCert)
                    .HasColumnName("Excellent_Cert")
                    .HasColumnType("varchar(128)")
                    .HasComment("优秀证书")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("int(11)")
                    .HasComment("项目id");

                entity.Property(e => e.ProjectName)
                    .HasColumnName("PROJECT_NAME")
                    .HasColumnType("varchar(512)")
                    .HasComment("项目名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Province)
                    .HasColumnName("PROVINCE")
                    .HasColumnType("varchar(20)")
                    .HasComment("省份")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.School)
                    .HasColumnName("SCHOOL")
                    .HasColumnType("varchar(128)")
                    .HasComment("学校")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Science)
                    .HasColumnName("SCIENCE")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.StudentId)
                    .HasColumnName("STUDENT_ID")
                    .HasColumnType("int(11)")
                    .HasComment("用户id");

                entity.Property(e => e.StudentLoginName)
                    .HasColumnName("STUDENT_LOGIN_NAME")
                    .HasColumnType("varchar(128)")
                    .HasComment("用户登录名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StudentName)
                    .HasColumnName("STUDENT_NAME")
                    .HasColumnType("varchar(128)")
                    .HasComment("用户姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StudySection)
                    .HasColumnName("STUDY_SECTION")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学段")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(128)")
                    .HasComment("教研组")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserType)
                    .HasColumnName("USER_TYPE")
                    .HasColumnType("varchar(1)")
                    .HasComment("用户角色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(128)")
                    .HasComment("工作坊")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Years)
                    .HasColumnName("YEARS")
                    .HasColumnType("int(11)")
                    .HasComment("年份");
            });

            modelBuilder.Entity<NtCloudCollege>(entity =>
            {
                entity.ToTable("nt_cloud_college");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AuthorInterview)
                    .HasColumnName("author_interview")
                    .HasColumnType("varchar(128)")
                    .HasComment("作者访谈（视频）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Catalog)
                    .HasColumnName("catalog")
                    .HasColumnType("varchar(1024)")
                    .HasComment("目录(最多10张图片)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Depict)
                    .HasColumnName("depict")
                    .HasColumnType("varchar(1024)")
                    .HasComment("描述(500字限制)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EditPath)
                    .HasColumnName("Edit_path")
                    .HasColumnType("varchar(1024)")
                    .HasComment("主编图片(最多10张图片)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Editor)
                    .HasColumnType("varchar(128)")
                    .HasComment("主编")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Guidance)
                    .HasColumnName("guidance")
                    .HasColumnType("varchar(128)")
                    .HasComment("指导")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImgPath)
                    .HasColumnName("img_path")
                    .HasColumnType("varchar(520)")
                    .HasComment("书图片")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("input_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(1024)")
                    .HasComment("关键字（详细页抽取相关书籍）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Postscript)
                    .HasColumnType("varchar(1024)")
                    .HasComment("后记(最多10张图片)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Preface)
                    .HasColumnName("preface")
                    .HasColumnType("varchar(1024)")
                    .HasComment("前言(最多10张图片)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Publishing)
                    .HasColumnName("publishing")
                    .HasColumnType("varchar(128)")
                    .HasComment("出版社")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Research)
                    .HasColumnName("research")
                    .HasColumnType("varchar(128)")
                    .HasComment("研发")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResourceFileId)
                    .HasColumnName("RESOURCE_FILE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(1024)")
                    .HasComment("标题（书籍名称）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NtCollegeApply>(entity =>
            {
                entity.ToTable("nt_college_apply");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .HasComment("ID");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasColumnType("varchar(64)")
                    .HasComment("详细地址")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ApplyState)
                    .HasColumnName("APPLY_STATE")
                    .HasColumnType("varchar(1)")
                    .HasComment("审核状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ApplyTime)
                    .HasColumnName("APPLY_TIME")
                    .HasColumnType("datetime")
                    .HasComment("申请时间");

                entity.Property(e => e.ApplyUserid)
                    .HasColumnName("APPLY_USERID")
                    .HasColumnType("int(11)")
                    .HasComment("申请人id");

                entity.Property(e => e.AuthorizeVoucher)
                    .HasColumnName("AUTHORIZE_VOUCHER")
                    .HasColumnType("varchar(512)")
                    .HasComment("授权凭证")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.BannerImg)
                    .HasColumnName("BANNER_IMG")
                    .HasColumnType("varchar(512)")
                    .HasComment("banner图片")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Cellphone)
                    .HasColumnName("CELLPHONE")
                    .HasColumnType("varchar(20)")
                    .HasComment("手机")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasColumnType("varchar(64)")
                    .HasComment("市")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.District)
                    .HasColumnName("DISTRICT")
                    .HasColumnType("varchar(64)")
                    .HasComment("区")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.DomainName)
                    .HasColumnName("DOMAIN_NAME")
                    .HasColumnType("varchar(100)")
                    .HasComment("域名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasColumnType("varchar(128)")
                    .HasComment("邮箱")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.FufeiEndTime)
                    .HasColumnName("FUFEI_END_TIME")
                    .HasColumnType("datetime")
                    .HasComment("付费截止时间");

                entity.Property(e => e.FufeiStartTime)
                    .HasColumnName("FUFEI_START_TIME")
                    .HasColumnType("datetime")
                    .HasComment("付费开始时间");

                entity.Property(e => e.IsCert)
                    .HasColumnName("IS_CERT")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否可打印证书（默认可打印）");

                entity.Property(e => e.IsFufei)
                    .HasColumnName("IS_FUFEI")
                    .HasColumnType("varchar(1)")
                    .HasComment("是否付费")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.IsRecommend)
                    .HasColumnName("IS_RECOMMEND")
                    .HasColumnType("varchar(1)")
                    .HasComment("是否推荐")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.LogImg)
                    .HasColumnName("LOG_IMG")
                    .HasColumnType("varchar(512)")
                    .HasComment("log图片")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(64)")
                    .HasComment("学校名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.OpeningTime)
                    .HasColumnName("OPENING_TIME")
                    .HasColumnType("datetime")
                    .HasComment("开通时间");

                entity.Property(e => e.PostCode)
                    .HasColumnName("POST_CODE")
                    .HasColumnType("varchar(64)")
                    .HasComment("邮政编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Province)
                    .HasColumnName("PROVINCE")
                    .HasColumnType("varchar(64)")
                    .HasComment("省")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.SchoolAdmin)
                    .HasColumnName("SCHOOL_ADMIN")
                    .HasColumnType("varchar(64)")
                    .HasComment("学校联系人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Studentpost)
                    .HasColumnName("STUDENTPOST")
                    .HasColumnType("varchar(20)")
                    .HasComment("职务")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Telephone)
                    .HasColumnName("TELEPHONE")
                    .HasColumnType("varchar(20)")
                    .HasComment("电话")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<NtCourse>(entity =>
            {
                entity.ToTable("nt_course");

                entity.HasIndex(e => e.IsApprovaled)
                    .HasName("IsApprovaled");

                entity.HasIndex(e => new { e.IsApprovaled, e.Style, e.Discipline, e.OrderNumber, e.Id })
                    .HasName("getCourse");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveDescription)
                    .HasColumnName("ACTIVE_DESCRIPTION")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AdminId)
                    .HasColumnName("ADMIN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApprovalTime)
                    .HasColumnName("APPROVAL_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.BbsDescription)
                    .HasColumnName("BBS_DESCRIPTION")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BookReview)
                    .HasColumnName("BOOK_REVIEW")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CertificateDescription)
                    .HasColumnName("CERTIFICATE_DESCRIPTION")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CertificateRequery)
                    .HasColumnName("CERTIFICATE_REQUERY")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClassHour)
                    .HasColumnName("class_hour")
                    .HasComment("学时");

                entity.Property(e => e.Clicks)
                    .HasColumnName("CLICKS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CourseStyle)
                    .HasColumnName("course_style")
                    .HasColumnType("int(11)")
                    .HasComment("课程形式(1讲座2课例3微课4其他)");

                entity.Property(e => e.Days)
                    .HasColumnName("DAYS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Discipline)
                    .HasColumnName("DISCIPLINE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DomainName)
                    .HasColumnName("DOMAIN_NAME")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ElectiveCount)
                    .HasColumnName("ELECTIVE_COUNT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnrollEndTime)
                    .HasColumnName("ENROLL_END_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnrollStartTime)
                    .HasColumnName("ENROLL_START_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnterAdminId)
                    .HasColumnName("ENTER_ADMIN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnterTime)
                    .HasColumnName("ENTER_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.EssentialDurationPercent).HasColumnName("ESSENTIAL_DURATION_PERCENT");

                entity.Property(e => e.ForumId)
                    .HasColumnName("FORUM_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HeadImgUrl)
                    .HasColumnName("HEAD_IMG_URL")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Host)
                    .HasColumnName("HOST")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsAdvanced)
                    .HasColumnName("is_advanced")
                    .HasColumnType("int(11)")
                    .HasComment("课程等级_是否高级(1是0否)");

                entity.Property(e => e.IsApprovaled)
                    .HasColumnName("IS_APPROVALED")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDisplayDiscuss)
                    .HasColumnName("IS_DISPLAY_DISCUSS")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDisplayEvent)
                    .HasColumnName("IS_DISPLAY_EVENT")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDisplaySource)
                    .HasColumnName("IS_DISPLAY_SOURCE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDisplayVideo)
                    .HasColumnName("IS_DISPLAY_VIDEO")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDisplayWork)
                    .HasColumnName("IS_DISPLAY_WORK")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsEightGrade)
                    .HasColumnName("is_eight_grade")
                    .HasColumnType("int(11)")
                    .HasComment("是否八年级(1是0否)");

                entity.Property(e => e.IsFifthGrade)
                    .HasColumnName("is_fifth_grade")
                    .HasColumnType("int(11)")
                    .HasComment("是否五年级(1是0否)");

                entity.Property(e => e.IsFourthGrade)
                    .HasColumnName("is_fourth_grade")
                    .HasColumnType("int(11)")
                    .HasComment("是否四年级(1是0否)");

                entity.Property(e => e.IsGeneralSection)
                    .HasColumnName("is_general_section")
                    .HasColumnType("int(11)")
                    .HasComment("是否通识类学段(1是0否)");

                entity.Property(e => e.IsHighOneGrade)
                    .HasColumnName("is_high_one_grade")
                    .HasColumnType("int(11)")
                    .HasComment("是否高中一年级(1是0否)");

                entity.Property(e => e.IsHighSchool)
                    .HasColumnName("is_high_school")
                    .HasColumnType("int(11)")
                    .HasComment("是否高中学段(1是0否)");

                entity.Property(e => e.IsHighThreeGrade)
                    .HasColumnName("is_high_three_grade")
                    .HasColumnType("int(11)")
                    .HasComment("是否高中三年级(1是0否)");

                entity.Property(e => e.IsHighTwoGrade)
                    .HasColumnName("is_high_two_grade")
                    .HasColumnType("int(11)")
                    .HasComment("是否高中二年级(1是0否)");

                entity.Property(e => e.IsIntermediate)
                    .HasColumnName("is_intermediate")
                    .HasColumnType("int(11)")
                    .HasComment("课程等级_是否中级(1是0否)");

                entity.Property(e => e.IsMiddleSchool)
                    .HasColumnName("is_middle_school")
                    .HasColumnType("int(11)")
                    .HasComment("是否初中学段(1是0否)");

                entity.Property(e => e.IsNecessaryEvent)
                    .HasColumnName("IS_NECESSARY_EVENT")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsNecessaryVideo)
                    .HasColumnName("IS_NECESSARY_VIDEO")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsNecessaryWork)
                    .HasColumnName("IS_NECESSARY_WORK")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsNineGrade)
                    .HasColumnName("is_nine_grade")
                    .HasColumnType("int(11)")
                    .HasComment("是否九年级(1是0否)");

                entity.Property(e => e.IsNurBigClass)
                    .HasColumnName("is_nur_big_class")
                    .HasColumnType("int(11)")
                    .HasComment("是否幼儿园大班(1是0否)");

                entity.Property(e => e.IsNurJuniorClass)
                    .HasColumnName("is_nur_junior_class")
                    .HasColumnType("int(11)")
                    .HasComment("是否幼儿园小班(1是0否)");

                entity.Property(e => e.IsNurMiddleClass)
                    .HasColumnName("is_nur_middle_class")
                    .HasColumnType("int(11)")
                    .HasComment("是否幼儿园中班(1是0否)");

                entity.Property(e => e.IsNurserySchool)
                    .HasColumnName("is_nursery_school")
                    .HasColumnType("int(11)")
                    .HasComment("是否幼儿园学段(1是0否)");

                entity.Property(e => e.IsOneGrade)
                    .HasColumnName("is_one_grade")
                    .HasColumnType("int(11)")
                    .HasComment("是否一年级(1是0否)");

                entity.Property(e => e.IsPrimary)
                    .HasColumnName("is_primary")
                    .HasColumnType("int(11)")
                    .HasComment("课程等级_是否初级(1是0否)");

                entity.Property(e => e.IsPrimarySchool)
                    .HasColumnName("is_primary_school")
                    .HasColumnType("int(11)")
                    .HasComment("是否小学学段(1是0否)");

                entity.Property(e => e.IsRecommended)
                    .HasColumnName("IS_RECOMMENDED")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsSevenGrade)
                    .HasColumnName("is_seven_grade")
                    .HasColumnType("int(11)")
                    .HasComment("是否七年级(1是0否)");

                entity.Property(e => e.IsSixGrade)
                    .HasColumnName("is_six_grade")
                    .HasColumnType("int(11)")
                    .HasComment("是否六年级(1是0否)");

                entity.Property(e => e.IsThreeGrade)
                    .HasColumnName("is_three_grade")
                    .HasColumnType("int(11)")
                    .HasComment("是否三年级(1是0否)");

                entity.Property(e => e.IsTwoGrade)
                    .HasColumnName("is_two_grade")
                    .HasColumnType("int(11)")
                    .HasComment("是否二年级(1是0否)");

                entity.Property(e => e.LiveBroadcastTime)
                    .HasColumnName("LIVE_BROADCAST_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.MainRequery)
                    .HasColumnName("MAIN_REQUERY")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("ORDER_NUMBER")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1000'");

                entity.Property(e => e.Payment).HasColumnName("PAYMENT");

                entity.Property(e => e.PreTestId)
                    .HasColumnName("PRE_TEST_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrimalSubjectId)
                    .HasColumnName("PRIMAL_SUBJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Science)
                    .HasColumnName("science")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.SelectRequery)
                    .HasColumnName("SELECT_REQUERY")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sort)
                    .HasColumnName("sort")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StudyRequery)
                    .HasColumnName("STUDY_REQUERY")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Style)
                    .HasColumnName("STYLE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubSubjectId)
                    .HasColumnName("SUB_SUBJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SucTestId)
                    .HasColumnName("SUC_TEST_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TeacherIds)
                    .HasColumnName("Teacher_IDs")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TeacherNames)
                    .HasColumnName("Teacher_Names")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TeamTeacher)
                    .HasColumnName("TEAM_TEACHER")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("TEMPLATE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ThirdSubjectId)
                    .HasColumnName("THIRD_SUBJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasColumnType("int(100)")
                    .HasComment("课程分类（专题类=1、案例类=2、微课知识类=3）");

                entity.Property(e => e.WorkDescription)
                    .HasColumnName("WORK_DESCRIPTION")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WorkRequery)
                    .HasColumnName("WORK_REQUERY")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WorkRequirementId)
                    .HasColumnName("WORK_REQUIREMENT_ID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NtCourseLabel>(entity =>
            {
                entity.ToTable("nt_course_label");

                entity.HasIndex(e => new { e.IsCopy, e.Clicks })
                    .HasName("get1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .HasComment("ID");

                entity.Property(e => e.Clicks)
                    .HasColumnName("CLICKS")
                    .HasColumnType("int(11)")
                    .HasComment("点击数");

                entity.Property(e => e.CourseId)
                    .HasColumnName("COURSE_ID")
                    .HasColumnType("int(11)")
                    .HasComment("课程id");

                entity.Property(e => e.InputTime)
                    .HasColumnName("INPUT_TIME")
                    .HasColumnType("datetime")
                    .HasComment("录入时间");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("INPUT_USER_ID")
                    .HasColumnType("int(11)")
                    .HasComment("录入人id");

                entity.Property(e => e.InputUserName)
                    .HasColumnName("INPUT_USER_NAME")
                    .HasColumnType("varchar(50)")
                    .HasComment("录入人姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsApprovaled)
                    .HasColumnName("IS_APPROVALED")
                    .HasColumnType("varchar(10)")
                    .HasComment("审核状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsCopy)
                    .HasColumnName("IS_COPY")
                    .HasColumnType("varchar(11)")
                    .HasComment("是否复制")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Label)
                    .HasColumnName("LABEL")
                    .HasColumnType("varchar(200)")
                    .HasComment("标签")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime")
                    .HasComment("更改时间");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("UPDATE_USER_ID")
                    .HasColumnType("int(11)")
                    .HasComment("更改人id");

                entity.Property(e => e.UpdateUserName)
                    .HasColumnName("UPDATE_USER_NAME")
                    .HasColumnType("varchar(50)")
                    .HasComment("更改人姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtCourseTeacher>(entity =>
            {
                entity.ToTable("nt_course_teacher");

                entity.HasIndex(e => e.CourseId)
                    .HasName("index_course_teacher_course_id");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CourseId)
                    .HasColumnName("COURSE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RelationType)
                    .HasColumnName("RELATION_TYPE")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Studying)
                    .HasColumnName("STUDYING")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TeacherId)
                    .HasColumnName("TEACHER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TeacherName)
                    .HasColumnName("TEACHER_NAME")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtCourseware>(entity =>
            {
                entity.ToTable("nt_courseware");

                entity.HasIndex(e => new { e.CourseId, e.OrderNumber })
                    .HasName("CourseIdOrderNumber");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CourseId)
                    .HasColumnName("COURSE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CoursewareType)
                    .HasColumnName("COURSEWARE_TYPE")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Duration)
                    .HasColumnName("DURATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImportTime)
                    .HasColumnName("IMPORT_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("IS_APPROVED")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsElective)
                    .HasColumnName("IS_ELECTIVE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Keyword)
                    .HasColumnName("KEYWORD")
                    .HasColumnType("varchar(100)")
                    .HasComment("关键字")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("ORDER_NUMBER")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1000'");

                entity.Property(e => e.RecordTime)
                    .HasColumnName("RECORD_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubCollege)
                    .HasColumnName("SUB_COLLEGE")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubLecturer)
                    .HasColumnName("SUB_LECTURER")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtCoursewareFile>(entity =>
            {
                entity.ToTable("nt_courseware_file");

                entity.HasIndex(e => new { e.CourseId, e.IsElective, e.ShowType })
                    .HasName("index_courseware_file");

                entity.HasIndex(e => new { e.CourseId, e.CoursewareId, e.ShowType, e.OrderNumber })
                    .HasName("get1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cmsid)
                    .HasColumnName("CMSID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CourseId)
                    .HasColumnName("COURSE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CoursewareId)
                    .HasColumnName("COURSEWARE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnName("DELIVERY_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeliveryStatus)
                    .HasColumnName("DELIVERY_STATUS")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.IsElective)
                    .HasColumnName("IS_ELECTIVE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("ORDER_NUMBER")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResourceFileId)
                    .HasColumnName("RESOURCE_FILE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResourceFilePath)
                    .HasColumnName("RESOURCE_FILE_PATH")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShowType)
                    .HasColumnName("SHOW_TYPE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsersId)
                    .HasColumnName("USERS_ID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NtFriend>(entity =>
            {
                entity.ToTable("nt_friend");

                entity.HasIndex(e => new { e.FriendId, e.MyFollow, e.FollowMy })
                    .HasName("get_follow");

                entity.HasIndex(e => new { e.UserId, e.MyFollow, e.FollowMy })
                    .HasName("get_friends");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Discipline)
                    .HasColumnName("DISCIPLINE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("DISTRICTCOUNTY")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FollowMy)
                    .HasColumnName("FOLLOW_MY")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FriendId)
                    .HasColumnName("FRIEND_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FriendType)
                    .HasColumnName("FRIEND_TYPE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromUsersHeadimg)
                    .HasColumnName("FROM_USERS_HEADIMG")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromUsersName)
                    .HasColumnName("FROM_USERS_NAME")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MyFollow)
                    .HasColumnName("MY_FOLLOW")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.School)
                    .HasColumnName("SCHOOL")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ToUsersHeadimg)
                    .HasColumnName("TO_USERS_HEADIMG")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ToUsersName)
                    .HasColumnName("TO_USERS_NAME")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtInvoiceRecords>(entity =>
            {
                entity.ToTable("nt_invoice_records");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .HasComment("主键");

                entity.Property(e => e.Amout)
                    .HasColumnName("AMOUT")
                    .HasColumnType("double(11,2)")
                    .HasComment("金额");

                entity.Property(e => e.BillAddressphone)
                    .HasColumnName("BILL_ADDRESSPHONE")
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''")
                    .HasComment("地址、电话")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BillBanknumber)
                    .HasColumnName("BILL_BANKNUMBER")
                    .HasColumnType("varchar(1024)")
                    .HasComment("开户行及账号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BillCompanyname)
                    .HasColumnName("BILL_COMPANYNAME")
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''")
                    .HasComment("发票抬头")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BillRemerk)
                    .HasColumnName("BILL_REMERK")
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BillTtaxpayernumber)
                    .HasColumnName("BILL_TTAXPAYERNUMBER")
                    .HasColumnType("varchar(128)")
                    .HasDefaultValueSql("''")
                    .HasComment("税号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Dataid)
                    .HasColumnName("DATAID")
                    .HasColumnType("int(11)")
                    .HasComment("数据ID");

                entity.Property(e => e.Datatype)
                    .HasColumnName("DATATYPE")
                    .HasColumnType("int(11)")
                    .HasComment("数据来源（1：基培，2：国培）");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''")
                    .HasComment("详细备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InputTime)
                    .HasColumnName("INPUT_TIME")
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("INPUT_USER_ID")
                    .HasColumnType("int(11)")
                    .HasComment("添加人ID");

                entity.Property(e => e.Invocenumber)
                    .HasColumnName("INVOCENUMBER")
                    .HasColumnType("varchar(1024)")
                    .HasComment("发票流水号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Invocepath)
                    .HasColumnName("INVOCEPATH")
                    .HasColumnType("varchar(1024)")
                    .HasComment("发票地址")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InvoiceRedYy)
                    .HasColumnName("INVOICE_RED_YY")
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''")
                    .HasComment("冲红原因（冲红时使用）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InvoiceRednumber)
                    .HasColumnName("INVOICE_REDNUMBER")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasComment("红票流水号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InvoiceRemerk)
                    .HasColumnName("INVOICE_REMERK")
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''")
                    .HasComment("冲红备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InvoiceUrl)
                    .HasColumnName("INVOICE_URL")
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''")
                    .HasComment("红票地址")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InvoiceYuannumberDm)
                    .HasColumnName("INVOICE_YUANNUMBER_DM")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasComment("原发票代码（冲红时使用）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InvoiceYuannumberHm)
                    .HasColumnName("INVOICE_YUANNUMBER_HM")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasComment("原发票号码（冲红时使用）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsApprovaled)
                    .HasColumnName("IS_APPROVALED")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''")
                    .HasComment("审核")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsInvoce)
                    .HasColumnName("IS_INVOCE")
                    .HasColumnType("int(11)")
                    .HasComment("是否已开发票（1：已开，2：未开）");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("ORDER_NUMBER")
                    .HasColumnType("int(11)")
                    .HasComment("排序");

                entity.Property(e => e.Orderid)
                    .HasColumnName("ORDERID")
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''")
                    .HasComment("订单编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordertype)
                    .HasColumnName("ORDERTYPE")
                    .HasColumnType("int(11)")
                    .HasComment("订单类型（1：基培集中项目缴费，2：基培混合培训缴费，3：基培购买学时，4：国培缴费）");

                entity.Property(e => e.StudentEmail)
                    .HasColumnName("STUDENT_EMAIL")
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''")
                    .HasComment("学员邮箱")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StudentId)
                    .HasColumnName("STUDENT_ID")
                    .HasColumnType("int(11)")
                    .HasComment("学员ID");

                entity.Property(e => e.StudentMob)
                    .HasColumnName("STUDENT_MOB")
                    .HasColumnType("varchar(11)")
                    .HasDefaultValueSql("''")
                    .HasComment("学员手机号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StudentName)
                    .HasColumnName("STUDENT_NAME")
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''")
                    .HasComment("学员姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("UPDATE_USER_ID")
                    .HasColumnType("int(11)")
                    .HasComment("更改人ID");
            });

            modelBuilder.Entity<NtKeywordFilter>(entity =>
            {
                entity.ToTable("nt_keyword_filter");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Content)
                    .HasColumnType("varchar(2000)")
                    .HasComment("内容（逗号分隔关键字）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("input_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(128)")
                    .HasComment("内容")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("状态（1是已审0是待审）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NtLive>(entity =>
            {
                entity.ToTable("nt_live");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BackgroundUrl)
                    .HasColumnName("BACKGROUND_URL")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CompereToken)
                    .HasColumnName("COMPERE_TOKEN")
                    .HasColumnType("text")
                    .HasComment("直播token")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CountryTop)
                    .HasColumnName("COUNTRY_TOP")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CountryTopTime)
                    .HasColumnName("COUNTRY_TOP_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CountyTop)
                    .HasColumnName("COUNTY_TOP")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CountyTopTime)
                    .HasColumnName("COUNTY_TOP_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Discipline)
                    .HasColumnName("DISCIPLINE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("DISTRICTCOUNTY")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DomainName)
                    .HasColumnName("DOMAIN_NAME")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Guest)
                    .HasColumnName("GUEST")
                    .HasColumnType("text")
                    .HasComment("主讲人简介")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HuiyiId)
                    .HasColumnName("HUIYI_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImgPath)
                    .HasColumnName("IMG_PATH")
                    .HasColumnType("varchar(512)")
                    .HasComment("直播图片")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InstructorToken)
                    .HasColumnName("INSTRUCTOR_TOKEN")
                    .HasColumnType("text")
                    .HasComment("回顾token")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Introduces)
                    .HasColumnName("INTRODUCES")
                    .HasColumnType("varchar(200)")
                    .HasComment("培训方式")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsApprovaled)
                    .HasColumnName("IS_APPROVALED")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsCounty)
                    .HasColumnName("IS_COUNTY")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsProvince)
                    .HasColumnName("IS_PROVINCE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JoinMax)
                    .HasColumnName("JOIN_MAX")
                    .HasColumnType("int(11)")
                    .HasComment("参与会议上限人数");

                entity.Property(e => e.LiveEndTime)
                    .HasColumnName("LIVE_END_TIME")
                    .HasColumnType("datetime")
                    .HasComment("结束时间");

                entity.Property(e => e.LiveTime)
                    .HasColumnName("LIVE_TIME")
                    .HasColumnType("datetime")
                    .HasComment("开始时间");

                entity.Property(e => e.LiveType)
                    .HasColumnName("LIVE_TYPE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Position)
                    .HasColumnName("POSITION")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrimalSubjectId)
                    .HasColumnName("PRIMAL_SUBJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Province)
                    .HasColumnName("PROVINCE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvinceTop)
                    .HasColumnName("PROVINCE_TOP")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvinceTopTime)
                    .HasColumnName("PROVINCE_TOP_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReviewUrl)
                    .HasColumnName("REVIEW_URL")
                    .HasColumnType("text")
                    .HasComment("回播路径")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.School)
                    .HasColumnName("SCHOOL")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SchoolId)
                    .HasColumnName("School_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SmallImgPath)
                    .HasColumnName("SMALL_IMG_PATH")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubSubjectId)
                    .HasColumnName("SUB_SUBJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SurplusJoin)
                    .HasColumnName("Surplus_Join")
                    .HasColumnType("int(11)")
                    .HasComment("已抢座人数");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ThirdSubjectId)
                    .HasColumnName("THIRD_SUBJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserName)
                    .HasColumnName("USER_NAME")
                    .HasColumnType("varchar(64)")
                    .HasComment("主讲人姓名(专家姓名)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasColumnType("int(11)")
                    .HasComment("主讲人id(专家id)");

                entity.Property(e => e.Weburl)
                    .HasColumnName("WEBURL")
                    .HasColumnType("varchar(100)")
                    .HasComment("直播路径")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtLivestudent>(entity =>
            {
                entity.ToTable("nt_livestudent");

                entity.HasIndex(e => new { e.StudentId, e.Id })
                    .HasName("get1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Discipline)
                    .HasColumnName("DISCIPLINE")
                    .HasColumnType("varchar(128)")
                    .HasComment("学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("DISTRICTCOUNTY")
                    .HasColumnType("varchar(128)")
                    .HasComment("区县")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JionContent)
                    .HasColumnType("text")
                    .HasComment("参加直播简介文本")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JoinFromType)
                    .HasColumnType("int(11)")
                    .HasComment("参与的直播类型");

                entity.Property(e => e.JoinState)
                    .HasColumnName("Join_State")
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasComment("参与直播状态(2为抢座,1为已参加)");

                entity.Property(e => e.JoinTime)
                    .HasColumnName("JOIN_TIME")
                    .HasColumnType("datetime")
                    .HasComment("参加时间");

                entity.Property(e => e.LiveId)
                    .HasColumnName("LIVE_ID")
                    .HasColumnType("int(11)")
                    .HasComment("直播ID");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("Project_id")
                    .HasColumnType("int(11)")
                    .HasComment("项目ID");

                entity.Property(e => e.Province)
                    .HasColumnName("PROVINCE")
                    .HasColumnType("varchar(128)")
                    .HasComment("省")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.School)
                    .HasColumnName("SCHOOL")
                    .HasColumnType("varchar(128)")
                    .HasComment("学校")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Science)
                    .HasColumnName("SCIENCE")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.StudentId)
                    .HasColumnName("STUDENT_ID")
                    .HasColumnType("int(11)")
                    .HasComment("用户ID");

                entity.Property(e => e.StudentName)
                    .HasColumnName("STUDENT_NAME")
                    .HasColumnType("varchar(500)")
                    .HasComment("学员姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StudentprojectId)
                    .HasColumnName("studentproject_id")
                    .HasColumnType("int(11)")
                    .HasComment("student_project表的id");

                entity.Property(e => e.StudySection)
                    .HasColumnName("STUDY_SECTION")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学段")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(128)")
                    .HasComment("教研组")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserType)
                    .HasColumnType("varchar(1)")
                    .HasComment("用户类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(128)")
                    .HasComment("工作坊")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Xian)
                    .HasColumnType("varchar(30)")
                    .HasComment("县")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtPrivateMessage>(entity =>
            {
                entity.ToTable("nt_private_message");

                entity.HasIndex(e => e.IsRead)
                    .HasName("getp");

                entity.HasIndex(e => e.MessageType)
                    .HasName("getp2");

                entity.HasIndex(e => new { e.IsRead, e.MessageType })
                    .HasName("getp1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Discipline)
                    .HasColumnName("DISCIPLINE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("DISTRICTCOUNTY")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DomainName)
                    .HasColumnName("DOMAIN_NAME")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromUsersId)
                    .HasColumnName("FROM_USERS_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FromUsersName)
                    .HasColumnName("FROM_USERS_NAME")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsRead)
                    .HasColumnName("IS_READ")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MessageType)
                    .HasColumnName("MESSAGE_TYPE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Province)
                    .HasColumnName("PROVINCE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.School)
                    .HasColumnName("SCHOOL")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SchoolId)
                    .HasColumnName("School_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Science)
                    .HasColumnName("SCIENCE")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.SendDate)
                    .HasColumnName("SEND_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SendIp)
                    .HasColumnName("SEND_IP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StudySection)
                    .HasColumnName("STUDY_SECTION")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学段")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ToUsersDeleteId)
                    .HasColumnName("TO_USERS_DELETE_ID")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ToUsersId)
                    .HasColumnName("TO_USERS_ID")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ToUsersName)
                    .HasColumnName("TO_USERS_NAME")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ToUsersReadId)
                    .HasColumnName("TO_USERS_READ_ID")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtProjectmanage>(entity =>
            {
                entity.ToTable("nt_projectmanage");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdminIds)
                    .HasColumnName("ADMIN_IDS")
                    .HasColumnType("varchar(1024)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AdminNames)
                    .HasColumnName("ADMIN_NAMES")
                    .HasColumnType("varchar(1024)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CourseCount)
                    .HasColumnName("COURSE_COUNT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DistrictcountyIds)
                    .HasColumnName("DISTRICTCOUNTY_IDS")
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DistrictcountyNames)
                    .HasColumnName("DISTRICTCOUNTY_NAMES")
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Dnsurl)
                    .IsRequired()
                    .HasColumnName("DNSURL")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EndTime)
                    .HasColumnName("END_TIME")
                    .HasColumnType("datetime")
                    .HasComment("项目结束时间");

                entity.Property(e => e.FinishDemand)
                    .HasColumnName("finish_demand")
                    .HasColumnType("varchar(512)")
                    .HasComment("毕业要求")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ForumTopics)
                    .HasColumnName("FORUM_TOPICS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("IMAGE")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("input_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsBlogs)
                    .HasColumnName("IS_BLOGS")
                    .HasColumnType("varchar(11)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsClose)
                    .HasColumnName("IS_CLOSE")
                    .HasColumnType("varchar(1)")
                    .HasComment("项目是否关闭，1=为关闭，0为正常。")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDisplaySusubject)
                    .HasColumnName("IS_DISPLAY_SUSUBJECT")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsGallery)
                    .HasColumnName("IS_GALLERY")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsLearningTasks)
                    .HasColumnName("is_learning_tasks")
                    .HasColumnType("varchar(1)")
                    .HasComment("坊主是否有学习任务")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsNetresource)
                    .HasColumnName("IS_NETRESOURCE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsSchoolbased)
                    .HasColumnName("IS_SCHOOLBASED")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsSelectMainnum)
                    .HasColumnName("is_select_mainnum")
                    .HasColumnType("varchar(1)")
                    .HasComment("组长是否有权限修改学员主线")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsWeike)
                    .HasColumnName("IS_WEIKE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MainnumIds)
                    .HasColumnName("MAINNUM_IDS")
                    .HasColumnType("text")
                    .HasComment("主线ids")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MainnumNames)
                    .HasColumnName("MAINNUM_NAMES")
                    .HasColumnType("text")
                    .HasComment("主线names")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Onlinetime)
                    .HasColumnName("ONLINETIME")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProjectPay)
                    .HasColumnName("project_pay")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否付费")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ProjectType)
                    .HasColumnName("Project_type")
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasComment("项目类型:国培(1)、非国培(2)、河北全员2016(3)、15年国培(4)、17年河北(5)");

                entity.Property(e => e.ProvinceIds)
                    .HasColumnName("PROVINCE_IDS")
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvinceName)
                    .HasColumnName("PROVINCE_NAME")
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RequiredCourse)
                    .HasColumnName("REQUIRED_COURSE")
                    .HasColumnType("varchar(2000)")
                    .HasComment("项目的必修课")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ScienceIds)
                    .HasColumnName("SCIENCE_ids")
                    .HasColumnType("varchar(1024)")
                    .HasComment("新学科ids")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ScienceNames)
                    .HasColumnName("SCIENCE_names")
                    .HasColumnType("varchar(1024)")
                    .HasComment("新学科names")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasColumnType("datetime")
                    .HasComment("项目开始时间");

                entity.Property(e => e.StartYear)
                    .HasColumnName("START_YEAR")
                    .HasColumnType("int(11)")
                    .HasComment("开始年份");

                entity.Property(e => e.SubjectId)
                    .HasColumnName("SUBJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SubjectIds)
                    .HasColumnName("SUBJECT_IDS")
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubjectName)
                    .HasColumnName("SUBJECT_NAME")
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Usertype1)
                    .HasColumnName("usertype1")
                    .HasColumnType("varchar(20)")
                    .HasComment("学员身份")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Usertype5)
                    .HasColumnName("usertype5")
                    .HasColumnType("varchar(20)")
                    .HasComment("区县管理员身份")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Usertype6)
                    .HasColumnName("usertype6")
                    .HasColumnType("varchar(20)")
                    .HasComment("坊主身份")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Usertype7)
                    .HasColumnName("usertype7")
                    .HasColumnType("varchar(20)")
                    .HasComment("校长身份")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Usertype8)
                    .HasColumnName("usertype8")
                    .HasColumnType("varchar(20)")
                    .HasComment("组长身份")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtProjectmanageFocus>(entity =>
            {
                entity.ToTable("nt_projectmanage_focus");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdminIds)
                    .HasColumnName("ADMIN_IDS")
                    .HasColumnType("varchar(1024)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AdminNames)
                    .HasColumnName("ADMIN_NAMES")
                    .HasColumnType("varchar(1024)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DistrictcountyIds)
                    .HasColumnName("DISTRICTCOUNTY_IDS")
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DistrictcountyNames)
                    .HasColumnName("DISTRICTCOUNTY_NAMES")
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Dnsurl)
                    .IsRequired()
                    .HasColumnName("DNSURL")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EndTime)
                    .HasColumnName("END_TIME")
                    .HasColumnType("datetime")
                    .HasComment("项目结束时间");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("IMAGE")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("input_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsClose)
                    .HasColumnName("IS_CLOSE")
                    .HasColumnType("varchar(1)")
                    .HasComment("项目是否关闭，1=为关闭，0为正常。")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MainnumIds)
                    .HasColumnName("MAINNUM_IDS")
                    .HasColumnType("text")
                    .HasComment("主线ids")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MainnumNames)
                    .HasColumnName("MAINNUM_NAMES")
                    .HasColumnType("text")
                    .HasComment("主线names")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayMoney)
                    .HasColumnName("pay_money")
                    .HasComment("交费金额");

                entity.Property(e => e.Peoples)
                    .HasColumnName("peoples")
                    .HasColumnType("int(11)")
                    .HasComment("人次");

                entity.Property(e => e.ProjectType)
                    .HasColumnName("Project_type")
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasComment("项目类型:集中(1)");

                entity.Property(e => e.ProvinceIds)
                    .HasColumnName("PROVINCE_IDS")
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvinceName)
                    .HasColumnName("PROVINCE_NAME")
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RequiredCourse)
                    .HasColumnName("REQUIRED_COURSE")
                    .HasColumnType("varchar(2000)")
                    .HasComment("项目的必修课")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasColumnType("datetime")
                    .HasComment("项目开始时间");

                entity.Property(e => e.StartYear)
                    .HasColumnName("START_YEAR")
                    .HasColumnType("int(11)")
                    .HasComment("开始年份");

                entity.Property(e => e.SubjectIds)
                    .HasColumnName("SUBJECT_IDS")
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubjectName)
                    .HasColumnName("SUBJECT_NAME")
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NtProjectmanageOrders>(entity =>
            {
                entity.ToTable("nt_projectmanage_orders");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(1024)")
                    .HasComment("地址")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BankcardNumber)
                    .HasColumnName("Bankcard_Number")
                    .HasColumnType("varchar(32)")
                    .HasComment("银行卡号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BankcardType)
                    .HasColumnName("Bankcard_Type")
                    .HasColumnType("int(11)")
                    .HasComment("银行卡类型");

                entity.Property(e => e.CardholderCardNumber)
                    .HasColumnName("Cardholder_CardNumber")
                    .HasColumnType("varchar(20)")
                    .HasComment("持卡人身份证号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardholderMobilePhone)
                    .HasColumnName("Cardholder_MobilePhone")
                    .HasColumnType("varchar(20)")
                    .HasComment("持卡人手机号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardholderName)
                    .HasColumnName("Cardholder_Name")
                    .HasColumnType("varchar(64)")
                    .HasComment("持卡人姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .HasColumnType("varchar(64)")
                    .HasComment("市")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Company)
                    .HasColumnType("varchar(128)")
                    .HasComment("单位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact_name")
                    .HasColumnType("varchar(128)")
                    .HasComment("联系人姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cvv2)
                    .HasColumnName("CVV2")
                    .HasColumnType("varchar(20)")
                    .HasComment("信用卡验证值（后三码）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.District)
                    .HasColumnType("varchar(64)")
                    .HasComment("区县")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(64)")
                    .HasComment("邮箱")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("input_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvoiceTitle)
                    .HasColumnName("Invoice_Title")
                    .HasColumnType("varchar(128)")
                    .HasComment("发票抬头")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDelete)
                    .HasColumnName("IS_Delete")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否删除");

                entity.Property(e => e.MobilePhone)
                    .HasColumnName("Mobile_phone")
                    .HasColumnType("varchar(20)")
                    .HasComment("手机")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(512)")
                    .HasComment("名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderNumber)
                    .IsRequired()
                    .HasColumnName("Order_Number")
                    .HasColumnType("varchar(128)")
                    .HasComment("订单编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayMoney)
                    .HasColumnName("pay_money")
                    .HasComment("实际交费金额");

                entity.Property(e => e.PaymentMethod)
                    .HasColumnName("Payment_Method")
                    .HasColumnType("int(11)")
                    .HasComment("付款方式：1支付宝，2银联，3现场交费（pos机）");

                entity.Property(e => e.PaymentState)
                    .HasColumnName("Payment_State")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("支付状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostCode)
                    .HasColumnName("Post_Code")
                    .HasColumnType("varchar(10)")
                    .HasComment("邮编")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("Project_ID")
                    .HasColumnType("int(11)")
                    .HasComment("项目id");

                entity.Property(e => e.Province)
                    .HasColumnType("varchar(64)")
                    .HasComment("省")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(255)")
                    .HasComment("发票备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TaxpayerNumber)
                    .HasColumnName("Taxpayer_Number")
                    .HasColumnType("varchar(32)")
                    .HasComment("纳税人识别码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TermOfValidity)
                    .HasColumnName("Term_of_validity")
                    .HasColumnType("int(11)")
                    .HasComment("卡有效期");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NtRegisterAppeal>(entity =>
            {
                entity.ToTable("nt_register_appeal");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AppealDescribe)
                    .HasColumnName("appeal_describe")
                    .HasColumnType("varchar(512)")
                    .HasComment("申诉描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AppealState)
                    .HasColumnName("appeal_state")
                    .HasColumnType("varchar(1)")
                    .HasComment("申诉状态(0未处理，1已处理)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AppealType)
                    .HasColumnName("appeal_type")
                    .HasColumnType("varchar(1)")
                    .HasComment("申诉类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cardnum)
                    .HasColumnName("cardnum")
                    .HasColumnType("varchar(30)")
                    .HasComment("身份证号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CardnumF)
                    .HasColumnName("cardnum_f")
                    .HasColumnType("varchar(512)")
                    .HasComment("身份证反面")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardnumZ)
                    .HasColumnName("cardnum_z")
                    .HasColumnType("varchar(512)")
                    .HasComment("身份证正面")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cellphone)
                    .HasColumnName("cellphone")
                    .HasColumnType("varchar(20)")
                    .HasComment("手机")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasColumnType("varchar(40)")
                    .HasComment("单位/学校")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.DisposeRecord)
                    .HasColumnName("dispose_record")
                    .HasColumnType("varchar(512)")
                    .HasComment("处理记录")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime")
                    .HasComment("添加日期");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("input_user_id")
                    .HasColumnType("int(11)")
                    .HasComment("用户id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasComment("姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)")
                    .HasComment("修改人id");
            });

            modelBuilder.Entity<NtResourceFile>(entity =>
            {
                entity.ToTable("nt_resource_file");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrowseTime)
                    .HasColumnName("browseTime")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Createtime)
                    .HasColumnName("CREATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Discipline)
                    .HasColumnName("DISCIPLINE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("DISTRICTCOUNTY")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Downloads)
                    .HasColumnName("DOWNLOADS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsPublished)
                    .HasColumnName("IS_PUBLISHED")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Labels)
                    .HasColumnName("LABELS")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Path)
                    .HasColumnName("PATH")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlayRuleId)
                    .HasColumnName("PLAY_RULE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrimalSubjectId)
                    .HasColumnName("PRIMAL_SUBJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Province)
                    .HasColumnName("PROVINCE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResourceId)
                    .HasColumnName("RESOURCE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.School)
                    .HasColumnName("SCHOOL")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Size)
                    .HasColumnName("SIZE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpTimes)
                    .HasColumnName("UP_TIMES")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UploadUser)
                    .HasColumnName("uploadUser")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtStudentProject>(entity =>
            {
                entity.ToTable("nt_student_project");

                entity.HasIndex(e => e.StudentId)
                    .HasName("Student_ID_Project");

                entity.HasIndex(e => new { e.ProjectId, e.StudentId })
                    .HasName("ProjectStudent_ID");

                entity.HasIndex(e => new { e.Province, e.UserType })
                    .HasName("getUsers8");

                entity.HasIndex(e => new { e.UserType, e.Id })
                    .HasName("get1");

                entity.HasIndex(e => new { e.ProjectId, e.UserType, e.Id })
                    .HasName("getUsers7");

                entity.HasIndex(e => new { e.UserType, e.StudentLoginNameMi, e.Id })
                    .HasName("get3");

                entity.HasIndex(e => new { e.ProjectId, e.Discipline, e.Workshop, e.Xian })
                    .HasName("getUsers6");

                entity.HasIndex(e => new { e.ProjectId, e.Districtcounty, e.Workshop, e.UserType })
                    .HasName("get2");

                entity.HasIndex(e => new { e.Province, e.Districtcounty, e.UserType, e.ProjectId })
                    .HasName("getUsers1");

                entity.HasIndex(e => new { e.ProjectId, e.Province, e.Districtcounty, e.School, e.UserType })
                    .HasName("getUsers3");

                entity.HasIndex(e => new { e.ProjectId, e.WorkShopId, e.TeachingGroupId, e.UserType, e.Id })
                    .HasName("getUsers4");

                entity.HasIndex(e => new { e.ProjectId, e.Province, e.Districtcounty, e.Workshop, e.UserType, e.Id })
                    .HasName("getUsers");

                entity.HasIndex(e => new { e.ProjectId, e.School, e.Mainnum, e.WorkShopId, e.TeachingGroupId, e.Id })
                    .HasName("getUsers5");

                entity.HasIndex(e => new { e.ProjectId, e.StudentName, e.Province, e.Districtcounty, e.School, e.UserType })
                    .HasName("getUsers2");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Addgloryid)
                    .HasColumnName("ADDGLORYID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Addgloryname)
                    .HasColumnName("ADDGLORYNAME")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Addglorytime)
                    .HasColumnName("ADDGLORYTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompletionCert)
                    .HasColumnName("Completion_Cert")
                    .HasColumnType("varchar(64)")
                    .HasComment("结业证书")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Discipline)
                    .HasColumnName("DISCIPLINE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("DISTRICTCOUNTY")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExcellentAdminCert)
                    .HasColumnName("Excellent_Admin_Cert")
                    .HasColumnType("varchar(64)")
                    .HasComment("优秀管理员证书")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExcellentCert)
                    .HasColumnName("Excellent_Cert")
                    .HasColumnType("varchar(64)")
                    .HasComment("优秀证书")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HnclassGuid)
                    .HasColumnName("hnclass_guid")
                    .HasColumnType("varchar(64)")
                    .HasComment("湖南学员classID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HomeworkCount).HasColumnType("int(11)");

                entity.Property(e => e.InputTime)
                    .HasColumnName("INPUT_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("INPUT_USER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsApprovaled)
                    .HasColumnName("IS_APPROVALED")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsRecommend)
                    .HasColumnType("int(11)")
                    .HasComment("是否推优");

                entity.Property(e => e.IsRecommendTime)
                    .HasColumnName("IsRecommend_Time")
                    .HasColumnType("datetime")
                    .HasComment("推优时间");

                entity.Property(e => e.Isglory)
                    .HasColumnName("ISGLORY")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LoginTimes)
                    .HasColumnName("LOGIN_TIMES")
                    .HasColumnType("int(11)")
                    .HasComment("登陆次数");

                entity.Property(e => e.Mainnum)
                    .HasColumnName("MAINNUM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OtherCert)
                    .HasColumnName("Other_Cert")
                    .HasColumnType("varchar(64)")
                    .HasComment("其它证书")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProjectImage)
                    .HasColumnName("PROJECT_IMAGE")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectName)
                    .HasColumnName("PROJECT_NAME")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Province)
                    .HasColumnName("PROVINCE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResourceCount).HasColumnType("int(11)");

                entity.Property(e => e.School)
                    .HasColumnName("SCHOOL")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Science)
                    .HasColumnName("SCIENCE")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.StudentId)
                    .HasColumnName("STUDENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StudentLoginName)
                    .HasColumnName("STUDENT_LOGIN_NAME")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.StudentLoginNameMi)
                    .HasColumnName("STUDENT_LOGIN_NAME_MI")
                    .HasColumnType("varchar(255)")
                    .HasComment("登录名mi")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StudentName)
                    .HasColumnName("STUDENT_NAME")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.StudySection)
                    .HasColumnName("STUDY_SECTION")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学段")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TeachingGroupId)
                    .HasColumnName("TeachingGroupID")
                    .HasColumnType("int(11)")
                    .HasComment("教研组ID");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("UPDATE_USER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserHeadImg)
                    .HasColumnName("USER_HEAD_IMG")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserType)
                    .HasColumnName("USER_TYPE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WorkShopId)
                    .HasColumnName("WorkShopID")
                    .HasColumnType("int(11)")
                    .HasComment("工作坊ID");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Xian)
                    .HasColumnName("XIAN")
                    .HasColumnType("varchar(11)")
                    .HasComment("县")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.XianId)
                    .HasColumnName("XIAN_ID")
                    .HasColumnType("int(11)")
                    .HasComment("县ID");
            });

            modelBuilder.Entity<NtStudentResourceFile>(entity =>
            {
                entity.ToTable("nt_student_resource_file");

                entity.HasIndex(e => new { e.StudentId, e.ProjectId })
                    .HasName("getFile1");

                entity.HasIndex(e => new { e.Discipline, e.Province, e.UserType })
                    .HasName("getFile");

                entity.HasIndex(e => new { e.IsApproved, e.TeacherIsapproved, e.WorkshopIsapproved, e.ProjectId, e.Title, e.Id })
                    .HasName("getRes2");

                entity.HasIndex(e => new { e.Province, e.Districtcounty, e.School, e.IsApproved, e.TeacherIsapproved, e.ProjectId })
                    .HasName("getRes4");

                entity.HasIndex(e => new { e.Province, e.UserType, e.IsApproved, e.TeacherIsapproved, e.WorkshopIsapproved, e.ProjectId, e.Id })
                    .HasName("getRes1");

                entity.HasIndex(e => new { e.Discipline, e.Province, e.UserType, e.IsApproved, e.TeacherIsapproved, e.WorkshopIsapproved, e.ProjectId, e.Id })
                    .HasName("getRes");

                entity.HasIndex(e => new { e.Discipline, e.Province, e.Districtcounty, e.Workshop, e.Teachinggroup, e.UserType, e.IsApproved, e.ProjectId, e.Id })
                    .HasName("getRes3");

                entity.HasIndex(e => new { e.Science, e.StudySection, e.Province, e.Districtcounty, e.Workshop, e.IsApproved, e.WorkshopIsapproved, e.ProjectId, e.UserType })
                    .HasName("getRes5");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CommentTime)
                    .HasColumnName("COMMENT_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Discipline)
                    .HasColumnName("DISCIPLINE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DisciplineType)
                    .HasColumnName("Discipline_Type")
                    .HasColumnType("int(11)")
                    .HasComment("学科分类app使用");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("DISTRICTCOUNTY")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DomainName)
                    .HasColumnName("DOMAIN_NAME")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Downloads)
                    .HasColumnName("DOWNLOADS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)")
                    .HasComment("关联的活动ID");

                entity.Property(e => e.GRecommended)
                    .HasColumnName("G_Recommended")
                    .HasColumnType("int(64)")
                    .HasComment("组长推荐");

                entity.Property(e => e.Grade)
                    .HasColumnType("int(11)")
                    .HasComment("年级app使用");

                entity.Property(e => e.GroupTopTime)
                    .HasColumnName("group_top_time")
                    .HasColumnType("datetime")
                    .HasComment("组长推荐时间");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("IS_APPROVED")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsRecommend)
                    .HasColumnName("is_Recommend")
                    .HasColumnType("int(11)")
                    .HasComment("是否推荐 0未，1已推荐");

                entity.Property(e => e.IsRecommendTime)
                    .HasColumnName("is_Recommend_time")
                    .HasColumnType("datetime")
                    .HasComment("推荐时间");

                entity.Property(e => e.Path)
                    .HasColumnName("PATH")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pointnumber)
                    .HasColumnType("int(11)")
                    .HasComment("点赞数");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("Project_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Province)
                    .HasColumnName("PROVINCE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RescorceFileType)
                    .HasColumnName("RescorceFile_Type")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResourceFileId)
                    .HasColumnName("RESOURCE_FILE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.School)
                    .HasColumnName("SCHOOL")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SchoolGrade)
                    .HasColumnName("School_Grade")
                    .HasColumnType("varchar(64)")
                    .HasComment("校级平台备课使用的年级")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SchoolId)
                    .HasColumnName("School_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Science)
                    .HasColumnName("SCIENCE")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Size)
                    .HasColumnName("SIZE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StudentId)
                    .HasColumnName("STUDENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StudySection)
                    .HasColumnName("STUDY_SECTION")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学段")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TeacherIsapproved)
                    .HasColumnName("Teacher_Isapproved")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserName)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserType)
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WRecommended)
                    .HasColumnName("W_Recommended")
                    .HasColumnType("int(64)")
                    .HasComment("坊主推荐人");

                entity.Property(e => e.WebResid)
                    .HasColumnName("WEB_RESID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WorkshopIsapproved)
                    .HasColumnName("Workshop_Isapproved")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WorkshopTopTime)
                    .HasColumnName("workshop_top_time")
                    .HasColumnType("datetime")
                    .HasComment("坊主推荐时间");

                entity.Property(e => e.Xian)
                    .HasColumnName("XIAN")
                    .HasColumnType("varchar(64)")
                    .HasComment("县")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ZjTop)
                    .HasColumnName("zj_top")
                    .HasColumnType("int(11)")
                    .HasComment("是否专家推荐");

                entity.Property(e => e.ZjTopTime)
                    .HasColumnName("zj_top_time")
                    .HasColumnType("datetime")
                    .HasComment("专家推荐时间");

                entity.Property(e => e.ZjTopUserid)
                    .HasColumnName("zj_top_userid")
                    .HasColumnType("int(11)")
                    .HasComment("专家推荐_专家id");
            });

            modelBuilder.Entity<NtTeProjectmanager>(entity =>
            {
                entity.ToTable("nt_te_projectmanager");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .HasComment("id");

                entity.Property(e => e.AdminIds)
                    .HasColumnName("ADMIN_IDS")
                    .HasColumnType("varchar(1024)")
                    .HasComment("管理员ids")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.AdminNames)
                    .HasColumnName("ADMIN_NAMES")
                    .HasColumnType("varchar(1024)")
                    .HasComment("管理员names")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ClassHour)
                    .HasColumnName("class_hour")
                    .HasComment("学时");

                entity.Property(e => e.CourseCount)
                    .HasColumnName("COURSE_COUNT")
                    .HasColumnType("int(11)")
                    .HasComment("课程数量");

                entity.Property(e => e.CourseIds)
                    .HasColumnName("COURSE_IDS")
                    .HasColumnType("text")
                    .HasComment("课程ids")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CourseNames)
                    .HasColumnName("COURSE_NAMES")
                    .HasColumnType("text")
                    .HasComment("课程names")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("text")
                    .HasComment("简介")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.EndTime)
                    .HasColumnName("END_TIME")
                    .HasColumnType("datetime")
                    .HasComment("结束时间");

                entity.Property(e => e.FinishDemand)
                    .HasColumnName("finish_demand")
                    .HasColumnType("varchar(512)")
                    .HasComment("完成要求")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Image)
                    .HasColumnName("IMAGE")
                    .HasColumnType("varchar(512)")
                    .HasComment("项目图片")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("input_user_id")
                    .HasColumnType("int(11)")
                    .HasComment("添加人id");

                entity.Property(e => e.IsClose)
                    .HasColumnName("IS_CLOSE")
                    .HasColumnType("varchar(1)")
                    .HasComment("是否关闭(0:否，1：是)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.KaibanAddress)
                    .HasColumnName("kaiban_address")
                    .HasColumnType("varchar(64)")
                    .HasComment("开班地址")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.KaibanTime)
                    .HasColumnName("kaiban_time")
                    .HasColumnType("datetime")
                    .HasComment("开班日期");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(100)")
                    .HasComment("名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ProjectType)
                    .HasColumnName("Project_type")
                    .HasColumnType("int(11)")
                    .HasComment("项目类型1为集中2为混合");

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasColumnType("datetime")
                    .HasComment("开始时间");

                entity.Property(e => e.StartYear)
                    .HasColumnName("START_YEAR")
                    .HasColumnType("int(11)")
                    .HasComment("开始年份");

                entity.Property(e => e.TarinNumberOfPeople)
                    .HasColumnName("tarin_Number_of_people")
                    .HasColumnType("int(11)")
                    .HasComment("报名人数");

                entity.Property(e => e.TrainCost)
                    .HasColumnName("train_cost")
                    .HasComment("费用");

                entity.Property(e => e.TrainCourseModality)
                    .HasColumnName("train_course_modality")
                    .HasColumnType("text")
                    .HasComment("课程模块")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TrainDuration)
                    .HasColumnName("train_duration")
                    .HasColumnType("varchar(64)")
                    .HasComment("培训时长")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TrainFeature)
                    .HasColumnName("train_feature")
                    .HasColumnType("text")
                    .HasComment("课程特色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TrainForm)
                    .HasColumnName("train_form")
                    .HasColumnType("text")
                    .HasComment("培训形式")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)")
                    .HasComment("修改人id");
            });

            modelBuilder.Entity<NtTeacher>(entity =>
            {
                entity.ToTable("nt_teacher");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Age)
                    .HasColumnName("AGE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApprovalTime)
                    .HasColumnName("APPROVAL_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.AssistantFive)
                    .HasColumnName("ASSISTANT_FIVE")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AssistantFour)
                    .HasColumnName("ASSISTANT_FOUR")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AssistantOne)
                    .HasColumnName("ASSISTANT_ONE")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AssistantPassword)
                    .HasColumnName("ASSISTANT_PASSWORD")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AssistantThree)
                    .HasColumnName("ASSISTANT_THREE")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AssistantTwo)
                    .HasColumnName("ASSISTANT_TWO")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BlogFlag)
                    .HasColumnName("BLOG_FLAG")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cellphone)
                    .HasColumnName("CELLPHONE")
                    .HasColumnType("varchar(16)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.College)
                    .HasColumnName("COLLEGE")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Discipline)
                    .HasColumnName("DISCIPLINE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.District)
                    .HasColumnName("DISTRICT")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("DISTRICTCOUNTY")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DomainName)
                    .HasColumnName("DOMAIN_NAME")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gender)
                    .HasColumnName("GENDER")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HeadImgUrl)
                    .HasColumnName("HEAD_IMG_URL")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsApprovaled)
                    .HasColumnName("IS_APPROVALED")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsInvited)
                    .HasColumnName("IS_INVITED")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsLiveHost)
                    .HasColumnName("IS_LIVE_HOST")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Major)
                    .HasColumnName("MAJOR")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nationality)
                    .HasColumnName("NATIONALITY")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostCode)
                    .HasColumnName("POST_CODE")
                    .HasColumnType("varchar(16)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Praise)
                    .HasColumnName("PRAISE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Province)
                    .HasColumnName("PROVINCE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.School)
                    .HasColumnName("SCHOOL")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Science)
                    .HasColumnName("SCIENCE")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Seniority)
                    .HasColumnName("SENIORITY")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StudySection)
                    .HasColumnName("STUDY_SECTION")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TeacherTitle)
                    .HasColumnName("TEACHER_TITLE")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Telephone)
                    .HasColumnName("TELEPHONE")
                    .HasColumnType("varchar(16)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtTransactions>(entity =>
            {
                entity.ToTable("nt_transactions");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(1024)")
                    .HasComment("地址")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BankcardNumber)
                    .HasColumnName("Bankcard_Number")
                    .HasColumnType("varchar(32)")
                    .HasComment("银行卡号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BankcardType)
                    .HasColumnName("Bankcard_Type")
                    .HasColumnType("int(11)")
                    .HasComment("银行卡类型");

                entity.Property(e => e.CardholderCardNumber)
                    .HasColumnName("Cardholder_CardNumber")
                    .HasColumnType("varchar(20)")
                    .HasComment("持卡人身份证号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardholderMobilePhone)
                    .HasColumnName("Cardholder_MobilePhone")
                    .HasColumnType("varchar(20)")
                    .HasComment("持卡人手机号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardholderName)
                    .HasColumnName("Cardholder_Name")
                    .HasColumnType("varchar(64)")
                    .HasComment("持卡人姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .HasColumnType("varchar(64)")
                    .HasComment("市")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Company)
                    .HasColumnType("varchar(128)")
                    .HasComment("单位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact_name")
                    .HasColumnType("varchar(128)")
                    .HasComment("联系人姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cvv2)
                    .HasColumnName("CVV2")
                    .HasColumnType("varchar(20)")
                    .HasComment("信用卡验证值（后三码）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.District)
                    .HasColumnType("varchar(64)")
                    .HasComment("区县")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(64)")
                    .HasComment("邮箱")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("input_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvoiceTitle)
                    .HasColumnName("Invoice_Title")
                    .HasColumnType("varchar(128)")
                    .HasComment("发票抬头")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDelete)
                    .HasColumnName("IS_Delete")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否删除");

                entity.Property(e => e.MobilePhone)
                    .HasColumnName("Mobile_phone")
                    .HasColumnType("varchar(20)")
                    .HasComment("手机")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(512)")
                    .HasComment("名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderNumber)
                    .IsRequired()
                    .HasColumnName("Order_Number")
                    .HasColumnType("varchar(128)")
                    .HasComment("订单编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayMoney)
                    .HasColumnName("pay_money")
                    .HasComment("实际交费金额");

                entity.Property(e => e.PaymentMethod)
                    .HasColumnName("Payment_Method")
                    .HasColumnType("int(11)")
                    .HasComment("付款方式：1支付宝，2银联，3现场交费（pos机）");

                entity.Property(e => e.PaymentState)
                    .HasColumnName("Payment_State")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("支付状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostCode)
                    .HasColumnName("Post_Code")
                    .HasColumnType("varchar(10)")
                    .HasComment("邮编")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("Project_ID")
                    .HasColumnType("int(11)")
                    .HasComment("项目id");

                entity.Property(e => e.Province)
                    .HasColumnType("varchar(64)")
                    .HasComment("省")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TaxpayerNumber)
                    .HasColumnName("Taxpayer_Number")
                    .HasColumnType("varchar(32)")
                    .HasComment("纳税人识别码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TermOfValidity)
                    .HasColumnName("Term_of_validity")
                    .HasColumnType("int(11)")
                    .HasComment("卡有效期");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NtUsers>(entity =>
            {
                entity.ToTable("nt_users");

                entity.HasIndex(e => e.CardnumMi)
                    .HasName("card_mi_index");

                entity.HasIndex(e => e.EmailMi)
                    .HasName("email_mi_index");

                entity.HasIndex(e => e.Name)
                    .HasName("getname");

                entity.HasIndex(e => new { e.Beizhuone, e.Province })
                    .HasName("bybeizhuone");

                entity.HasIndex(e => new { e.Cellphone, e.IsCellphoneVerified })
                    .HasName("cellphone");

                entity.HasIndex(e => new { e.CellphoneMi, e.IsCellphoneVerified })
                    .HasName("cellphone_mi_index");

                entity.HasIndex(e => new { e.LoginName, e.Password })
                    .HasName("UsersLoginNoType");

                entity.HasIndex(e => new { e.LoginNameMi, e.Password })
                    .HasName("login_mi_index");

                entity.HasIndex(e => new { e.Province, e.City })
                    .HasName("getCount");

                entity.HasIndex(e => new { e.Province, e.Id })
                    .HasName("GetUsersByProvince");

                entity.HasIndex(e => new { e.SchoolId, e.Id })
                    .HasName("get1");

                entity.HasIndex(e => new { e.LoginName, e.Password, e.UserType })
                    .HasName("UserLogin");

                entity.HasIndex(e => new { e.UserType, e.Discipline, e.Districtcounty, e.Workshop, e.Teachinggroup, e.Isglory })
                    .HasName("getbytype");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .HasComment("ID");

                entity.Property(e => e.Academy)
                    .HasColumnName("ACADEMY")
                    .HasColumnType("varchar(256)")
                    .HasComment("培训院校")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Addgloryid)
                    .HasColumnName("ADDGLORYID")
                    .HasColumnType("int(11)")
                    .HasComment("添加人id");

                entity.Property(e => e.Addgloryname)
                    .HasColumnName("ADDGLORYNAME")
                    .HasColumnType("varchar(50)")
                    .HasComment("添加人姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Addglorytime)
                    .HasColumnName("ADDGLORYTIME")
                    .HasColumnType("datetime")
                    .HasComment("上榜时间");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasColumnType("varchar(100)")
                    .HasComment("详细地址")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Beizhuone)
                    .HasColumnName("BEIZHUONE")
                    .HasColumnType("varchar(200)")
                    .HasComment("备注1")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Beizhuthree)
                    .HasColumnName("BEIZHUTHREE")
                    .HasColumnType("varchar(256)")
                    .HasComment("备注3")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Beizhutwo)
                    .HasColumnName("BEIZHUTWO")
                    .HasColumnType("varchar(256)")
                    .HasComment("备注2")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Business)
                    .HasColumnName("BUSINESS")
                    .HasColumnType("varchar(40)")
                    .HasComment("职称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Cardnum)
                    .HasColumnName("CARDNUM")
                    .HasColumnType("varchar(30)")
                    .HasComment("身份证号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CardnumMi)
                    .HasColumnName("CARDNUM_MI")
                    .HasColumnType("varchar(255)")
                    .HasComment("身份证mi")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Cellphone)
                    .HasColumnName("CELLPHONE")
                    .HasColumnType("varchar(20)")
                    .HasComment("手机")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CellphoneJp)
                    .HasColumnName("CELLPHONE_JP")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CellphoneJpMi)
                    .HasColumnName("CELLPHONE_JP_MI")
                    .HasColumnType("varchar(255)")
                    .HasComment("手机号mi_基培")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CellphoneMi)
                    .HasColumnName("CELLPHONE_MI")
                    .HasColumnType("varchar(255)")
                    .HasComment("手机号mi")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CellphoneSchool)
                    .HasColumnName("CELLPHONE_SCHOOL")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CellphoneSchoolMi)
                    .HasColumnName("CELLPHONE_SCHOOL_MI")
                    .HasColumnType("varchar(255)")
                    .HasComment("手机号mi_校级平台")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasColumnType("varchar(64)")
                    .HasComment("市")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasColumnType("varchar(40)")
                    .HasComment("单位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CompletionCert)
                    .HasColumnName("COMPLETION_CERT")
                    .HasColumnType("varchar(64)")
                    .HasComment("结业证书")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Discipline)
                    .HasColumnName("DISCIPLINE")
                    .HasColumnType("varchar(64)")
                    .HasComment("学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.District)
                    .HasColumnName("DISTRICT")
                    .HasColumnType("varchar(64)")
                    .HasComment("区")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("DISTRICTCOUNTY")
                    .HasColumnType("varchar(64)")
                    .HasComment("区县")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasColumnType("varchar(64)")
                    .HasComment("邮箱")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.EmailMi)
                    .HasColumnName("EMAIL_MI")
                    .HasColumnType("varchar(255)")
                    .HasComment("邮箱mi")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("date")
                    .HasComment("入职时间");

                entity.Property(e => e.ExcellentAdminCert)
                    .HasColumnName("EXCELLENT_ADMIN_CERT")
                    .HasColumnType("varchar(64)")
                    .HasComment("优秀管理员证书")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ExcellentCert)
                    .HasColumnName("EXCELLENT_CERT")
                    .HasColumnType("varchar(64)")
                    .HasComment("优秀学员证书")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.HeadImgUrl)
                    .HasColumnName("HEAD_IMG_URL")
                    .HasColumnType("varchar(512)")
                    .HasComment("用户头像")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.HighestEducation)
                    .HasColumnName("Highest_Education")
                    .HasColumnType("varchar(15)")
                    .HasComment("最高学历")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Homeworkcount)
                    .HasColumnName("HOMEWORKCOUNT")
                    .HasColumnType("int(11)")
                    .HasComment("日志数");

                entity.Property(e => e.InputTime)
                    .HasColumnName("INPUT_TIME")
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("INPUT_USER_ID")
                    .HasColumnType("int(11)")
                    .HasComment("添加人id");

                entity.Property(e => e.IsApprovaled)
                    .HasColumnName("is_approvaled")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否审核");

                entity.Property(e => e.IsCellphoneJpVerified)
                    .HasColumnName("IS_CELLPHONE_JP_VERIFIED")
                    .HasColumnType("int(1)");

                entity.Property(e => e.IsCellphoneSchoolVerified)
                    .HasColumnName("IS_CELLPHONE_SCHOOL_VERIFIED")
                    .HasColumnType("int(1)");

                entity.Property(e => e.IsCellphoneVerified)
                    .HasColumnName("IS_CELLPHONE_VERIFIED")
                    .HasColumnType("int(1)");

                entity.Property(e => e.IsFufei)
                    .HasColumnName("is_fufei")
                    .HasColumnType("int(1)")
                    .HasComment("是否为付费用户");

                entity.Property(e => e.IsGpjh)
                    .HasColumnName("IS_GPJH")
                    .HasColumnType("int(11)")
                    .HasComment("是否国培计划;20180629用于存储年龄");

                entity.Property(e => e.IsSchoolAdmin)
                    .HasColumnName("IS_SCHOOL_ADMIN")
                    .HasColumnType("varchar(1)")
                    .HasComment("是否学校管理员")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.IsZgks)
                    .HasColumnName("IS_ZGKS")
                    .HasColumnType("int(11)")
                    .HasComment("是否资格考试;20180629用于存储教龄");

                entity.Property(e => e.Isglory)
                    .HasColumnName("ISGLORY")
                    .HasColumnType("int(11)")
                    .HasComment("光荣榜");

                entity.Property(e => e.LastLoginIp)
                    .HasColumnName("LAST_LOGIN_IP")
                    .HasColumnType("varchar(20)")
                    .HasComment("最后登陆ip")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.LastLoginTime)
                    .HasColumnName("LAST_LOGIN_TIME")
                    .HasColumnType("datetime")
                    .HasComment("最后登陆时间");

                entity.Property(e => e.LoginName)
                    .HasColumnName("LOGIN_NAME")
                    .HasColumnType("varchar(50)")
                    .HasComment("登陆名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.LoginNameMi)
                    .HasColumnName("LOGIN_NAME_MI")
                    .HasColumnType("varchar(255)")
                    .HasComment("登录名mi")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.LoginTimes)
                    .HasColumnName("LOGIN_TIMES")
                    .HasColumnType("int(11)")
                    .HasComment("登陆次数");

                entity.Property(e => e.Mainnum)
                    .HasColumnName("MAINNUM")
                    .HasColumnType("int(11)")
                    .HasComment("主线");

                entity.Property(e => e.MajorStudied)
                    .HasColumnName("Major_studied")
                    .HasColumnType("varchar(128)")
                    .HasComment("所学专业")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(50)")
                    .HasComment("姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Nationality)
                    .HasColumnName("NATIONALITY")
                    .HasColumnType("varchar(200)")
                    .HasComment("民族")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.NickName)
                    .HasColumnName("NICK_NAME")
                    .HasColumnType("varchar(50)")
                    .HasComment("昵称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.NumberOfPosts)
                    .HasColumnName("NUMBER_OF_POSTS")
                    .HasColumnType("int(11)")
                    .HasComment("帖子数");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasColumnType("varchar(50)")
                    .HasComment("密码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.PaymentPassword)
                    .HasColumnType("varchar(40)")
                    .HasComment("支付密码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostCode)
                    .HasColumnName("POST_CODE")
                    .HasColumnType("varchar(20)")
                    .HasComment("邮政编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("int(11)")
                    .HasComment("项目id");

                entity.Property(e => e.Projects)
                    .HasColumnName("PROJECTS")
                    .HasColumnType("varchar(400)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Province)
                    .HasColumnName("PROVINCE")
                    .HasColumnType("varchar(64)")
                    .HasComment("省")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Qq)
                    .HasColumnName("QQ")
                    .HasColumnType("varchar(20)")
                    .HasComment("QQ号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Resourcecount)
                    .HasColumnName("RESOURCECOUNT")
                    .HasColumnType("int(11)")
                    .HasComment("资源数");

                entity.Property(e => e.RolesId)
                    .HasColumnName("roles_id")
                    .HasColumnType("int(11)")
                    .HasComment("角色id");

                entity.Property(e => e.School)
                    .HasColumnName("SCHOOL")
                    .HasColumnType("varchar(64)")
                    .HasComment("学校")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.SchoolId)
                    .HasColumnName("SCHOOL_ID")
                    .HasColumnType("int(11)")
                    .HasComment("院校中心ID");

                entity.Property(e => e.Score)
                    .HasColumnName("SCORE")
                    .HasComment("红包积分");

                entity.Property(e => e.Sex)
                    .HasColumnName("SEX")
                    .HasColumnType("varchar(1)")
                    .HasComment("性别")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Signature)
                    .HasColumnName("SIGNATURE")
                    .HasColumnType("varchar(200)")
                    .HasComment("个性签名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Studentpost)
                    .HasColumnName("STUDENTPOST")
                    .HasColumnType("varchar(40)")
                    .HasComment("职务")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasColumnType("varchar(40)")
                    .HasComment("真实学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasComment("教研组")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Telephone)
                    .HasColumnName("TELEPHONE")
                    .HasColumnType("varchar(20)")
                    .HasComment("座机")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Token)
                    .HasColumnName("TOKEN")
                    .HasColumnType("varchar(50)")
                    .HasComment("标识")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TopicCount)
                    .HasColumnName("TOPIC_COUNT")
                    .HasColumnType("int(11)")
                    .HasComment("解答问题数");

                entity.Property(e => e.TopicType)
                    .HasColumnName("TOPIC_TYPE")
                    .HasColumnType("varchar(400)")
                    .HasComment("解答问题类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Township)
                    .HasColumnType("varchar(128)")
                    .HasComment("乡级行政区")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TypeFlag)
                    .HasColumnName("TYPE_FLAG")
                    .HasColumnType("varchar(1)")
                    .HasComment("用户类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.University)
                    .HasColumnType("varchar(128)")
                    .HasComment("毕业院校")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasColumnName("USER_TYPE")
                    .HasColumnType("varchar(1)")
                    .HasComment("用户类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Village)
                    .HasColumnType("varchar(128)")
                    .HasComment("村级行政区")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(64)")
                    .HasComment("工作坊")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ZgksCellphone)
                    .HasColumnName("ZGKS_CELLPHONE")
                    .HasColumnType("varchar(15)")
                    .HasComment("资格考试手机号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtUsersJx>(entity =>
            {
                entity.ToTable("nt_users_jx");

                entity.HasIndex(e => e.CardnumMi)
                    .HasName("card_mi_index");

                entity.HasIndex(e => e.EmailMi)
                    .HasName("email_mi_index");

                entity.HasIndex(e => e.Name)
                    .HasName("getname");

                entity.HasIndex(e => new { e.Beizhuone, e.Province })
                    .HasName("bybeizhuone");

                entity.HasIndex(e => new { e.Cellphone, e.IsCellphoneVerified })
                    .HasName("cellphone");

                entity.HasIndex(e => new { e.CellphoneMi, e.IsCellphoneVerified })
                    .HasName("cellphone_mi_index");

                entity.HasIndex(e => new { e.LoginName, e.Password })
                    .HasName("UsersLoginNoType");

                entity.HasIndex(e => new { e.LoginNameMi, e.Password })
                    .HasName("login_mi_index");

                entity.HasIndex(e => new { e.Province, e.City })
                    .HasName("getCount");

                entity.HasIndex(e => new { e.Province, e.Id })
                    .HasName("GetUsersByProvince");

                entity.HasIndex(e => new { e.SchoolId, e.Id })
                    .HasName("get1");

                entity.HasIndex(e => new { e.LoginName, e.Password, e.UserType })
                    .HasName("UserLogin");

                entity.HasIndex(e => new { e.UserType, e.Discipline, e.Districtcounty, e.Workshop, e.Teachinggroup, e.Isglory })
                    .HasName("getbytype");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .HasComment("ID");

                entity.Property(e => e.Academy)
                    .HasColumnName("ACADEMY")
                    .HasColumnType("varchar(256)")
                    .HasComment("培训院校")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Addgloryid)
                    .HasColumnName("ADDGLORYID")
                    .HasColumnType("int(11)")
                    .HasComment("添加人id");

                entity.Property(e => e.Addgloryname)
                    .HasColumnName("ADDGLORYNAME")
                    .HasColumnType("varchar(50)")
                    .HasComment("添加人姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Addglorytime)
                    .HasColumnName("ADDGLORYTIME")
                    .HasColumnType("datetime")
                    .HasComment("上榜时间");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasColumnType("varchar(100)")
                    .HasComment("详细地址")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Beizhuone)
                    .HasColumnName("BEIZHUONE")
                    .HasColumnType("varchar(200)")
                    .HasComment("备注1")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Beizhuthree)
                    .HasColumnName("BEIZHUTHREE")
                    .HasColumnType("varchar(256)")
                    .HasComment("备注3")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Beizhutwo)
                    .HasColumnName("BEIZHUTWO")
                    .HasColumnType("varchar(256)")
                    .HasComment("备注2")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Business)
                    .HasColumnName("BUSINESS")
                    .HasColumnType("varchar(40)")
                    .HasComment("职称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Cardnum)
                    .HasColumnName("CARDNUM")
                    .HasColumnType("varchar(30)")
                    .HasComment("身份证号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CardnumMi)
                    .HasColumnName("CARDNUM_MI")
                    .HasColumnType("varchar(255)")
                    .HasComment("身份证mi")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Cellphone)
                    .HasColumnName("CELLPHONE")
                    .HasColumnType("varchar(20)")
                    .HasComment("手机")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CellphoneJp)
                    .HasColumnName("CELLPHONE_JP")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CellphoneJpMi)
                    .HasColumnName("CELLPHONE_JP_MI")
                    .HasColumnType("varchar(255)")
                    .HasComment("手机号mi_基培")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CellphoneMi)
                    .HasColumnName("CELLPHONE_MI")
                    .HasColumnType("varchar(255)")
                    .HasComment("手机号mi")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CellphoneSchool)
                    .HasColumnName("CELLPHONE_SCHOOL")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CellphoneSchoolMi)
                    .HasColumnName("CELLPHONE_SCHOOL_MI")
                    .HasColumnType("varchar(255)")
                    .HasComment("手机号mi_校级平台")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasColumnType("varchar(64)")
                    .HasComment("市")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasColumnType("varchar(40)")
                    .HasComment("单位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CompletionCert)
                    .HasColumnName("COMPLETION_CERT")
                    .HasColumnType("varchar(64)")
                    .HasComment("结业证书")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Discipline)
                    .HasColumnName("DISCIPLINE")
                    .HasColumnType("varchar(64)")
                    .HasComment("学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.District)
                    .HasColumnName("DISTRICT")
                    .HasColumnType("varchar(64)")
                    .HasComment("区")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("DISTRICTCOUNTY")
                    .HasColumnType("varchar(64)")
                    .HasComment("区县")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasColumnType("varchar(64)")
                    .HasComment("邮箱")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.EmailMi)
                    .HasColumnName("EMAIL_MI")
                    .HasColumnType("varchar(255)")
                    .HasComment("邮箱mi")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("date")
                    .HasComment("入职时间");

                entity.Property(e => e.ExcellentAdminCert)
                    .HasColumnName("EXCELLENT_ADMIN_CERT")
                    .HasColumnType("varchar(64)")
                    .HasComment("优秀管理员证书")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ExcellentCert)
                    .HasColumnName("EXCELLENT_CERT")
                    .HasColumnType("varchar(64)")
                    .HasComment("优秀学员证书")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.HeadImgUrl)
                    .HasColumnName("HEAD_IMG_URL")
                    .HasColumnType("varchar(512)")
                    .HasComment("用户头像")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.HighestEducation)
                    .HasColumnName("Highest_Education")
                    .HasColumnType("varchar(15)")
                    .HasComment("最高学历")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Homeworkcount)
                    .HasColumnName("HOMEWORKCOUNT")
                    .HasColumnType("int(11)")
                    .HasComment("日志数");

                entity.Property(e => e.InputTime)
                    .HasColumnName("INPUT_TIME")
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("INPUT_USER_ID")
                    .HasColumnType("int(11)")
                    .HasComment("添加人id");

                entity.Property(e => e.IsApprovaled)
                    .HasColumnName("is_approvaled")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否审核");

                entity.Property(e => e.IsCellphoneJpVerified)
                    .HasColumnName("IS_CELLPHONE_JP_VERIFIED")
                    .HasColumnType("int(1)");

                entity.Property(e => e.IsCellphoneSchoolVerified)
                    .HasColumnName("IS_CELLPHONE_SCHOOL_VERIFIED")
                    .HasColumnType("int(1)");

                entity.Property(e => e.IsCellphoneVerified)
                    .HasColumnName("IS_CELLPHONE_VERIFIED")
                    .HasColumnType("int(1)");

                entity.Property(e => e.IsFufei)
                    .HasColumnName("is_fufei")
                    .HasColumnType("int(1)")
                    .HasComment("是否为付费用户");

                entity.Property(e => e.IsGpjh)
                    .HasColumnName("IS_GPJH")
                    .HasColumnType("int(11)")
                    .HasComment("是否国培计划;20180629用于存储年龄");

                entity.Property(e => e.IsSchoolAdmin)
                    .HasColumnName("IS_SCHOOL_ADMIN")
                    .HasColumnType("varchar(1)")
                    .HasComment("是否学校管理员")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.IsZgks)
                    .HasColumnName("IS_ZGKS")
                    .HasColumnType("int(11)")
                    .HasComment("是否资格考试;20180629用于存储教龄");

                entity.Property(e => e.Isglory)
                    .HasColumnName("ISGLORY")
                    .HasColumnType("int(11)")
                    .HasComment("光荣榜");

                entity.Property(e => e.LastLoginIp)
                    .HasColumnName("LAST_LOGIN_IP")
                    .HasColumnType("varchar(20)")
                    .HasComment("最后登陆ip")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.LastLoginTime)
                    .HasColumnName("LAST_LOGIN_TIME")
                    .HasColumnType("datetime")
                    .HasComment("最后登陆时间");

                entity.Property(e => e.LoginName)
                    .HasColumnName("LOGIN_NAME")
                    .HasColumnType("varchar(50)")
                    .HasComment("登陆名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.LoginNameMi)
                    .HasColumnName("LOGIN_NAME_MI")
                    .HasColumnType("varchar(255)")
                    .HasComment("登录名mi")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.LoginTimes)
                    .HasColumnName("LOGIN_TIMES")
                    .HasColumnType("int(11)")
                    .HasComment("登陆次数");

                entity.Property(e => e.Mainnum)
                    .HasColumnName("MAINNUM")
                    .HasColumnType("int(11)")
                    .HasComment("主线");

                entity.Property(e => e.MajorStudied)
                    .HasColumnName("Major_studied")
                    .HasColumnType("varchar(128)")
                    .HasComment("所学专业")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(50)")
                    .HasComment("姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Nationality)
                    .HasColumnName("NATIONALITY")
                    .HasColumnType("varchar(200)")
                    .HasComment("民族")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.NickName)
                    .HasColumnName("NICK_NAME")
                    .HasColumnType("varchar(50)")
                    .HasComment("昵称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.NumberOfPosts)
                    .HasColumnName("NUMBER_OF_POSTS")
                    .HasColumnType("int(11)")
                    .HasComment("帖子数");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasColumnType("varchar(50)")
                    .HasComment("密码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.PaymentPassword)
                    .HasColumnType("varchar(40)")
                    .HasComment("支付密码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostCode)
                    .HasColumnName("POST_CODE")
                    .HasColumnType("varchar(20)")
                    .HasComment("邮政编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("int(11)")
                    .HasComment("项目id");

                entity.Property(e => e.Projects)
                    .HasColumnName("PROJECTS")
                    .HasColumnType("varchar(400)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Province)
                    .HasColumnName("PROVINCE")
                    .HasColumnType("varchar(64)")
                    .HasComment("省")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Qq)
                    .HasColumnName("QQ")
                    .HasColumnType("varchar(20)")
                    .HasComment("QQ号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Resourcecount)
                    .HasColumnName("RESOURCECOUNT")
                    .HasColumnType("int(11)")
                    .HasComment("资源数");

                entity.Property(e => e.RolesId)
                    .HasColumnName("roles_id")
                    .HasColumnType("int(11)")
                    .HasComment("角色id");

                entity.Property(e => e.School)
                    .HasColumnName("SCHOOL")
                    .HasColumnType("varchar(64)")
                    .HasComment("学校")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.SchoolId)
                    .HasColumnName("SCHOOL_ID")
                    .HasColumnType("int(11)")
                    .HasComment("院校中心ID");

                entity.Property(e => e.Score)
                    .HasColumnName("SCORE")
                    .HasComment("红包积分");

                entity.Property(e => e.Sex)
                    .HasColumnName("SEX")
                    .HasColumnType("varchar(1)")
                    .HasComment("性别")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Signature)
                    .HasColumnName("SIGNATURE")
                    .HasColumnType("varchar(200)")
                    .HasComment("个性签名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Studentpost)
                    .HasColumnName("STUDENTPOST")
                    .HasColumnType("varchar(40)")
                    .HasComment("职务")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasColumnType("varchar(40)")
                    .HasComment("真实学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasComment("教研组")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Telephone)
                    .HasColumnName("TELEPHONE")
                    .HasColumnType("varchar(20)")
                    .HasComment("座机")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Token)
                    .HasColumnName("TOKEN")
                    .HasColumnType("varchar(50)")
                    .HasComment("标识")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TopicCount)
                    .HasColumnName("TOPIC_COUNT")
                    .HasColumnType("int(11)")
                    .HasComment("解答问题数");

                entity.Property(e => e.TopicType)
                    .HasColumnName("TOPIC_TYPE")
                    .HasColumnType("varchar(400)")
                    .HasComment("解答问题类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Township)
                    .HasColumnType("varchar(128)")
                    .HasComment("乡级行政区")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TypeFlag)
                    .HasColumnName("TYPE_FLAG")
                    .HasColumnType("varchar(1)")
                    .HasComment("用户类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.University)
                    .HasColumnType("varchar(128)")
                    .HasComment("毕业院校")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasColumnName("USER_TYPE")
                    .HasColumnType("varchar(1)")
                    .HasComment("用户类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Village)
                    .HasColumnType("varchar(128)")
                    .HasComment("村级行政区")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(64)")
                    .HasComment("工作坊")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ZgksCellphone)
                    .HasColumnName("ZGKS_CELLPHONE")
                    .HasColumnType("varchar(15)")
                    .HasComment("资格考试手机号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtWeikeResource>(entity =>
            {
                entity.ToTable("nt_weike_resource");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlbumId)
                    .HasColumnName("ALBUM_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cmsid)
                    .HasColumnName("CMSID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CountryTop)
                    .HasColumnName("COUNTRY_TOP")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CountryTopTime)
                    .HasColumnName("COUNTRY_TOP_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CountyTop)
                    .HasColumnName("COUNTY_TOP")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CountyTopTime)
                    .HasColumnName("COUNTY_TOP_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delivery)
                    .HasColumnName("DELIVERY")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Discipline)
                    .HasColumnName("DISCIPLINE")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("DISTRICTCOUNTY")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EncodeState)
                    .HasColumnName("ENCODE_STATE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EncodeTime)
                    .HasColumnName("ENCODE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ifshow)
                    .HasColumnName("IFSHOW")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InFileImg)
                    .HasColumnName("IN_FILE_IMG")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InFileName)
                    .HasColumnName("IN_FILE_NAME")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InFileNameOld)
                    .HasColumnName("IN_FILE_NAME_OLD")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InFilePath)
                    .HasColumnName("IN_FILE_PATH")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InFilePatten)
                    .HasColumnName("IN_FILE_PATTEN")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InFilePic)
                    .HasColumnName("IN_FILE_PIC")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InFileSize)
                    .HasColumnName("IN_FILE_SIZE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InFileType)
                    .HasColumnName("IN_FILE_TYPE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsApprovaled)
                    .HasColumnName("IS_APPROVALED")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsCounty)
                    .HasColumnName("IS_COUNTY")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsProvince)
                    .HasColumnName("IS_PROVINCE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsPublic)
                    .HasColumnName("IS_PUBLIC")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutFileName)
                    .HasColumnName("OUT_FILE_NAME")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutFilePath)
                    .HasColumnName("OUT_FILE_PATH")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrimalSubjectId)
                    .HasColumnName("PRIMAL_SUBJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Province)
                    .HasColumnName("PROVINCE")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvinceTop)
                    .HasColumnName("PROVINCE_TOP")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvinceTopTime)
                    .HasColumnName("PROVINCE_TOP_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.School)
                    .HasColumnName("SCHOOL")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Science)
                    .HasColumnName("SCIENCE")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.StudySection)
                    .HasColumnName("STUDY_SECTION")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学段")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UploadDate)
                    .HasColumnName("UPLOAD_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsersId)
                    .HasColumnName("USERS_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsersProvince)
                    .HasColumnName("USERS_PROVINCE")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsersSchool)
                    .HasColumnName("USERS_SCHOOL")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Vodsize)
                    .HasColumnName("VODSIZE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
