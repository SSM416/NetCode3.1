using System;
using gp_DataBase.DbExtend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace gp_DataBase.gp15_base_Models
{
    public partial class gp15_baseContext : EFCoreAllContext
    {
        public gp15_baseContext(string conn) : base(conn)
        {
        }

        public gp15_baseContext(DbContextOptions<gp15_baseContext> options)
            : base(options.ToString())
        {
        }

        public virtual DbSet<Henaninterfacelog> Henaninterfacelog { get; set; }
        public virtual DbSet<NtActions> NtActions { get; set; }
        public virtual DbSet<NtActivationCode> NtActivationCode { get; set; }
        public virtual DbSet<NtAddArea> NtAddArea { get; set; }
        public virtual DbSet<NtAddress> NtAddress { get; set; }
        public virtual DbSet<NtAnswer> NtAnswer { get; set; }
        public virtual DbSet<NtConfig> NtConfig { get; set; }
        public virtual DbSet<NtCoverPicture> NtCoverPicture { get; set; }
        public virtual DbSet<NtCredit> NtCredit { get; set; }
        public virtual DbSet<NtEvent> NtEvent { get; set; }
        public virtual DbSet<NtHandinhand> NtHandinhand { get; set; }
        public virtual DbSet<NtInfor> NtInfor { get; set; }
        public virtual DbSet<NtLabel> NtLabel { get; set; }
        public virtual DbSet<NtLearning> NtLearning { get; set; }
        public virtual DbSet<NtMainnum> NtMainnum { get; set; }
        public virtual DbSet<NtNotice> NtNotice { get; set; }
        public virtual DbSet<NtPhaseLearning> NtPhaseLearning { get; set; }
        public virtual DbSet<NtQuestion> NtQuestion { get; set; }
        public virtual DbSet<NtRequestKeyword> NtRequestKeyword { get; set; }
        public virtual DbSet<NtRoles> NtRoles { get; set; }
        public virtual DbSet<NtRolesActions> NtRolesActions { get; set; }
        public virtual DbSet<NtTeacherCourse> NtTeacherCourse { get; set; }
        public virtual DbSet<NtTeacherCourseware> NtTeacherCourseware { get; set; }
        public virtual DbSet<NtTeacherEvent> NtTeacherEvent { get; set; }
        public virtual DbSet<NtTeacherEventMainnum> NtTeacherEventMainnum { get; set; }
        public virtual DbSet<NtTest> NtTest { get; set; }
        public virtual DbSet<NtTheme> NtTheme { get; set; }
        public virtual DbSet<NtUserLabel> NtUserLabel { get; set; }
        public virtual DbSet<NtUsersRoles> NtUsersRoles { get; set; }
        public virtual DbSet<NtWindow> NtWindow { get; set; }
        public virtual DbSet<Ntv2Attribute> Ntv2Attribute { get; set; }
        public virtual DbSet<Ntv2CourseTopic> Ntv2CourseTopic { get; set; }
        public virtual DbSet<Ntv2CoursetopicCourse> Ntv2CoursetopicCourse { get; set; }
        public virtual DbSet<Ntv2EventCourse> Ntv2EventCourse { get; set; }
        public virtual DbSet<Ntv2IntegralRules> Ntv2IntegralRules { get; set; }
        public virtual DbSet<Ntv2LogRecord> Ntv2LogRecord { get; set; }
        public virtual DbSet<Ntv2MasterSlave> Ntv2MasterSlave { get; set; }
        public virtual DbSet<Sequence> Sequence { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=10.1.140.119;database=gp15_base;uid=gpjh;pwd=123456", x => x.ServerVersion("5.6.21-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Henaninterfacelog>(entity =>
            {
                entity.ToTable("henaninterfacelog");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

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

                entity.Property(e => e.CellphoneSchool)
                    .HasColumnName("CELLPHONE_SCHOOL")
                    .HasColumnType("varchar(15)")
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

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

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
                    .HasComment("是否审核");

                entity.Property(e => e.IsCellphoneJpVerified)
                    .HasColumnName("IS_CELLPHONE_JP_VERIFIED")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsCellphoneSchoolVerified)
                    .HasColumnName("IS_CELLPHONE_SCHOOL_VERIFIED")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsCellphoneVerified)
                    .HasColumnName("IS_CELLPHONE_VERIFIED")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsGpjh)
                    .HasColumnName("IS_GPJH")
                    .HasColumnType("int(11)")
                    .HasComment("是否国培计划");

                entity.Property(e => e.IsSchoolAdmin)
                    .HasColumnName("IS_SCHOOL_ADMIN")
                    .HasColumnType("varchar(1)")
                    .HasComment("是否学校管理员")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.IsZgks)
                    .HasColumnName("IS_ZGKS")
                    .HasColumnType("int(11)")
                    .HasComment("是否资格考试");

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

                entity.Property(e => e.OperationType).HasColumnType("int(11)");

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasColumnType("varchar(50)")
                    .HasComment("密码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.PaymentPassword)
                    .HasColumnType("varchar(40)")
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

                entity.Property(e => e.ProjectName)
                    .HasColumnName("PROJECT_Name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

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

                entity.Property(e => e.RelationId)
                    .HasColumnName("RelationID")
                    .HasColumnType("int(11)");

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

                entity.Property(e => e.Science)
                    .HasColumnName("SCIENCE")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

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

                entity.Property(e => e.StudySection)
                    .HasColumnName("STUDY_SECTION")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学段")
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

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserType)
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

            modelBuilder.Entity<NtActions>(entity =>
            {
                entity.ToTable("nt_actions");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActionType)
                    .HasColumnName("ACTION_TYPE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FId)
                    .HasColumnName("F_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsCommented)
                    .HasColumnName("IS_COMMENTED")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsMenu)
                    .HasColumnName("IS_MENU")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsToken)
                    .HasColumnName("IS_TOKEN")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Listaction)
                    .HasColumnName("LISTACTION")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Listactionname)
                    .HasColumnName("LISTACTIONNAME")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Listshow)
                    .HasColumnName("LISTSHOW")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Listshowname)
                    .HasColumnName("LISTSHOWNAME")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("ORDER_NUMBER")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PId)
                    .HasColumnName("P_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoleType)
                    .HasColumnName("ROLE_TYPE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Target)
                    .HasColumnName("TARGET")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserTypes)
                    .HasColumnName("USER_TYPES")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtActivationCode>(entity =>
            {
                entity.ToTable("nt_activation_code");

                entity.HasIndex(e => e.ActivationCode)
                    .HasName("activation_code");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActivationCode)
                    .HasColumnName("activation_code")
                    .HasColumnType("varchar(20)")
                    .HasComment("激活码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Discipline)
                    .HasColumnName("discipline")
                    .HasColumnType("varchar(64)")
                    .HasComment("学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("districtcounty")
                    .HasColumnType("varchar(64)")
                    .HasComment("区")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("input_user_id")
                    .HasColumnType("int(11)")
                    .HasComment("生成者ID");

                entity.Property(e => e.InputUserName)
                    .HasColumnName("input_user_name")
                    .HasColumnType("varchar(512)")
                    .HasComment("生成者姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InputUserTime)
                    .HasColumnName("input_user_time")
                    .HasColumnType("datetime")
                    .HasComment("生成时间");

                entity.Property(e => e.IsUse)
                    .HasColumnName("is_use")
                    .HasColumnType("int(11)")
                    .HasComment("是否使用");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("int(11)")
                    .HasComment("项目id");

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasColumnType("varchar(64)")
                    .HasComment("省")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvinceCode)
                    .HasColumnName("province_code")
                    .HasColumnType("varchar(64)")
                    .HasComment("省份代码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.School)
                    .HasColumnName("school")
                    .HasColumnType("varchar(64)")
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
                    .HasColumnName("student_id")
                    .HasColumnType("int(11)")
                    .HasComment("使用者ID");

                entity.Property(e => e.StudentName)
                    .HasColumnName("student_name")
                    .HasColumnType("varchar(512)")
                    .HasComment("使用人姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StudySection)
                    .HasColumnName("STUDY_SECTION")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学段")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("teachinggroup")
                    .HasColumnType("varchar(64)")
                    .HasComment("教研组")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UseTime)
                    .HasColumnName("use_time")
                    .HasColumnType("datetime")
                    .HasComment("使用时间");

                entity.Property(e => e.UseYear)
                    .HasColumnName("use_year")
                    .HasColumnType("varchar(4)")
                    .HasComment("使用年份")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserType)
                    .HasColumnName("user_type")
                    .HasColumnType("varchar(1)")
                    .HasComment("使用者类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnName("workshop")
                    .HasColumnType("varchar(64)")
                    .HasComment("工作坊")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Xian)
                    .HasColumnName("xian")
                    .HasColumnType("varchar(64)")
                    .HasComment("县")
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
                    .HasColumnName("XIAN")
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
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnName("PARENT_ID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NtAnswer>(entity =>
            {
                entity.ToTable("nt_answer");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AnswerType)
                    .HasColumnName("ANSWER_TYPE")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("CONTENT")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("ORDER_NUMBER")
                    .HasColumnType("int(11)");

                entity.Property(e => e.QuestionId)
                    .HasColumnName("QUESTION_ID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NtConfig>(entity =>
            {
                entity.ToTable("nt_config");

                entity.HasIndex(e => new { e.Fieldtitle, e.ProjectId })
                    .HasName("get1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fieldnotes)
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fieldtitle)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fieldtype)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fieldvalue)
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("Project_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProjectName)
                    .HasColumnName("Project_name")
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtCoverPicture>(entity =>
            {
                entity.ToTable("nt_cover_picture");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hyperlink)
                    .HasColumnName("HYPERLINK")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PictureType)
                    .HasColumnName("PICTURE_TYPE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PictureUrl)
                    .HasColumnName("PICTURE_URL")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProjectName)
                    .HasColumnName("PROJECT_NAME")
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtCredit>(entity =>
            {
                entity.ToTable("nt_credit");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("Project_id_in");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .HasComment("id");

                entity.Property(e => e.CasestudyEvent)
                    .HasColumnName("CASESTUDY_EVENT")
                    .HasComment("案例分析活动分");

                entity.Property(e => e.CommentLimit)
                    .HasColumnName("COMMENT_LIMIT")
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasComment("评论上限");

                entity.Property(e => e.ElectiveCourserEvent)
                    .HasColumnName("ELECTIVE_COURSER_EVENT")
                    .HasComment("选学课程活动分");

                entity.Property(e => e.EnrollmentLimit)
                    .HasColumnName("ENROLLMENT_LIMIT")
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasComment("课程学习(选修)上限");

                entity.Property(e => e.EtcaeterasLimt)
                    .HasColumnName("ETCAETERAS_LIMT")
                    .HasComment("主线外各项上限分");

                entity.Property(e => e.EtcaeterasLimtTeachinggroup)
                    .HasColumnName("ETCAETERAS_LIMT_TEACHINGGROUP")
                    .HasComment("主线外各项上限分_教研组");

                entity.Property(e => e.EtcaeterasLimtWorkshop)
                    .HasColumnName("ETCAETERAS_LIMT_WORKSHOP")
                    .HasComment("主线外各项上限分_坊主");

                entity.Property(e => e.FullMarks)
                    .HasColumnName("full_Marks")
                    .HasComment("满分");

                entity.Property(e => e.GiveNotice)
                    .HasColumnName("give_notice")
                    .HasColumnType("double(11,0)");

                entity.Property(e => e.GiveNoticeLimit)
                    .HasColumnName("give_notice_limit")
                    .HasColumnType("double(11,0)");

                entity.Property(e => e.GroupMerge)
                    .HasColumnName("GROUP_MERGE")
                    .HasColumnType("varchar(256)")
                    .HasComment("组长合计上限项")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.HandinhandLimit)
                    .HasColumnName("HANDINHAND_LIMIT")
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasComment("手拉手上限");

                entity.Property(e => e.HomeworkLimit)
                    .HasColumnName("HOMEWORK_LIMIT")
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasComment("日志上限");

                entity.Property(e => e.HomeworkTopLimit)
                    .HasColumnName("HOMEWORK_TOP_LIMIT")
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasComment("推荐日志上限");

                entity.Property(e => e.InputTime)
                    .HasColumnName("INPUT_TIME")
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("INPUT_USER_ID")
                    .HasColumnType("int(11)")
                    .HasComment("添加人");

                entity.Property(e => e.IsApprovaled)
                    .HasColumnName("IS_APPROVALED")
                    .HasColumnType("char(1)")
                    .HasComment("是否审核")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.IsSjmark)
                    .HasColumnName("is_sjmark")
                    .HasColumnType("int(1)")
                    .HasComment("是否有实践活动，=0是没有，=1是优秀合格，=2是具体分数");

                entity.Property(e => e.Live)
                    .HasColumnName("LIVE")
                    .HasComment("观看直播分");

                entity.Property(e => e.LiveEvent)
                    .HasColumnName("LIVE_EVENT")
                    .HasComment("直播活动分");

                entity.Property(e => e.LiveLimt)
                    .HasColumnName("LIVE_LIMT")
                    .HasComment("观看直播分上限");

                entity.Property(e => e.MainnumeventLimt)
                    .HasColumnName("MAINNUMEVENT_LIMT")
                    .HasComment("主线活动上限分");

                entity.Property(e => e.MainnumeventLimtTeachinggroup)
                    .HasColumnName("MAINNUMEVENT_LIMT_TEACHINGGROUP")
                    .HasComment("主线活动上限分_教研组");

                entity.Property(e => e.MainnumeventLimtWorkshop)
                    .HasColumnName("MAINNUMEVENT_LIMT_WORKSHOP")
                    .HasComment("主线活动上限分_坊主");

                entity.Property(e => e.NoticeLimit)
                    .HasColumnName("NOTICE_LIMIT")
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasComment("公告简报上限");

                entity.Property(e => e.OnlinetimeLimit)
                    .HasColumnName("ONLINETIME_LIMIT")
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasComment("在线时长上限");

                entity.Property(e => e.Passes).HasComment("及格分");

                entity.Property(e => e.PercentrateLimit)
                    .HasColumnName("PERCENTRATE_LIMIT")
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasDefaultValueSql("'00000000001'")
                    .HasComment("百分百及格率上限");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("int(11)")
                    .HasComment("项目id");

                entity.Property(e => e.QuestionEvent)
                    .HasColumnName("QUESTION_EVENT")
                    .HasComment("在线调查活动分");

                entity.Property(e => e.QxandXzMerge)
                    .HasColumnName("QXAndXZ_MERGE")
                    .HasColumnType("varchar(256)")
                    .HasComment("区县管理员和校长的合计上限项")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ReadingEvent)
                    .HasColumnName("READING_EVENT")
                    .HasComment("文本阅读活动分");

                entity.Property(e => e.RequiredCourseEvent)
                    .HasColumnName("REQUIRED_COURSE_EVENT")
                    .HasComment("课程学习活动分");

                entity.Property(e => e.ResourceEvent)
                    .HasColumnName("RESOURCE_EVENT")
                    .HasComment("资源上传活动分");

                entity.Property(e => e.ResourcesLimit)
                    .HasColumnName("RESOURCES_LIMIT")
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasComment("资源上限");

                entity.Property(e => e.ResourcesTopLimit)
                    .HasColumnName("RESOURCES_TOP_LIMIT")
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasComment("推荐资源上限");

                entity.Property(e => e.SjmarkLimit)
                    .HasColumnName("sjmark_limit")
                    .HasColumnType("int(11)")
                    .HasComment("实践活动上线分");

                entity.Property(e => e.StudentMerge)
                    .HasColumnName("STUDENT_MERGE")
                    .HasColumnType("varchar(256)")
                    .HasComment("学员合计上限项")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("UPDATE_USER_ID")
                    .HasColumnType("int(11)")
                    .HasComment("修改人");

                entity.Property(e => e.WeikeEvent)
                    .HasColumnName("WEIKE_EVENT")
                    .HasComment("微课上传活动分");

                entity.Property(e => e.WeikesLimit)
                    .HasColumnName("WEIKES_LIMIT")
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasComment(" 微课上限");

                entity.Property(e => e.WorkshopMerge)
                    .HasColumnName("WORKSHOP_MERGE")
                    .HasColumnType("varchar(256)")
                    .HasComment("坊主合计上限项")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<NtEvent>(entity =>
            {
                entity.ToTable("nt_event");

                entity.HasIndex(e => e.Type)
                    .HasName("byType");

                entity.HasIndex(e => new { e.EventTime, e.Id })
                    .HasName("get1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdminId)
                    .HasColumnName("ADMIN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BookIds)
                    .HasColumnName("BOOK_IDS")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BookNames)
                    .HasColumnName("BOOK_NAMES")
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

                entity.Property(e => e.EnterAdminId)
                    .HasColumnName("ENTER_ADMIN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnterTime)
                    .HasColumnName("ENTER_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventContent)
                    .HasColumnName("EVENT_CONTENT")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EventHarvest)
                    .HasColumnName("Event_harvest")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EventLimit)
                    .HasColumnName("EVENT_LIMIT")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EventTime)
                    .HasColumnName("EVENT_TIME")
                    .HasColumnType("date");

                entity.Property(e => e.EventTimeEnd)
                    .HasColumnName("EVENT_TIME_End")
                    .HasColumnType("date");

                entity.Property(e => e.EventType)
                    .HasColumnName("EVENT_TYPE")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HeadImgUrl)
                    .HasColumnName("HEAD_IMG_URL")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsApprovaled)
                    .HasColumnName("IS_APPROVALED")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsCopy)
                    .HasColumnName("IS_COPY")
                    .HasColumnType("int(1) unsigned zerofill")
                    .HasComment("是否复制");

                entity.Property(e => e.IsMainnumEvent)
                    .HasColumnName("IS_MAINNUM_EVENT")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NumberOfPeople)
                    .HasColumnName("NUMBER_OF_PEOPLE")
                    .HasColumnType("int(11)");

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

                entity.Property(e => e.Sort)
                    .HasColumnName("sort")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StandardChaptersNum)
                    .HasColumnName("standard_Chapters_num")
                    .HasColumnType("int(11)")
                    .HasComment("达标章节数");

                entity.Property(e => e.StudentName)
                    .HasColumnName("Student_name")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TestId)
                    .HasColumnName("TEST_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtHandinhand>(entity =>
            {
                entity.ToTable("nt_handinhand");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DisciplineFrom)
                    .HasColumnName("DISCIPLINE_FROM")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DisciplineTo)
                    .HasColumnName("DISCIPLINE_TO")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DistrictcountyFrom)
                    .HasColumnName("DISTRICTCOUNTY_FROM")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DistrictcountyTo)
                    .HasColumnName("DISTRICTCOUNTY_TO")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("input_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsApprovaled)
                    .HasColumnName("IS_APPROVALED")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JoinFrom)
                    .HasColumnName("JOIN_FROM")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JoinTo)
                    .HasColumnName("JOIN_TO")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JoinType)
                    .HasColumnName("JOIN_TYPE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LaudNumber)
                    .HasColumnName("Laud_Number")
                    .HasColumnType("int(11)")
                    .HasComment("点赞数");

                entity.Property(e => e.ProvinceFrom)
                    .HasColumnName("PROVINCE_FROM")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvinceTo)
                    .HasColumnName("PROVINCE_TO")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SchoolFrom)
                    .HasColumnName("SCHOOL_FROM")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SchoolTo)
                    .HasColumnName("SCHOOL_TO")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ScienceFrom)
                    .HasColumnName("SCIENCE_FROM")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ScienceTo)
                    .HasColumnName("SCIENCE_TO")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.StudentNameFrom)
                    .HasColumnName("StudentName_From")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StudySectionFrom)
                    .HasColumnName("STUDY_SECTION_FROM")
                    .HasColumnType("varchar(128)")
                    .HasDefaultValueSql("''")
                    .HasComment("新学段")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.StudySectionTo)
                    .HasColumnName("STUDY_SECTION_TO")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学段")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TeachinggroupFrom)
                    .HasColumnName("TEACHINGGROUP_From")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TeachinggroupTo)
                    .HasColumnName("TEACHINGGROUP_To")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NtInfor>(entity =>
            {
                entity.ToTable("nt_infor");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .HasComment("ID");

                entity.Property(e => e.AuditTime)
                    .HasColumnName("AUDIT_TIME")
                    .HasColumnType("datetime")
                    .HasComment("审核时间");

                entity.Property(e => e.Clicks)
                    .HasColumnName("CLICKS")
                    .HasColumnType("int(11)")
                    .HasComment("点赞数");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasColumnType("int(11)")
                    .HasComment("评论数");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasColumnType("longtext")
                    .HasComment("内容")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.InputTime)
                    .HasColumnName("INPUT_TIME")
                    .HasColumnType("datetime")
                    .HasComment("录入时间");

                entity.Property(e => e.InputUserid)
                    .HasColumnName("INPUT_USERID")
                    .HasColumnType("int(11)")
                    .HasComment("录入人员");

                entity.Property(e => e.InputUsername)
                    .HasColumnName("INPUT_USERNAME")
                    .HasColumnType("varchar(100)")
                    .HasComment("录入人姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.IsApprovaled)
                    .HasColumnName("IS_APPROVALED")
                    .HasColumnType("int(11)")
                    .HasComment("审核状态 0为否 1为是");

                entity.Property(e => e.IsTop)
                    .HasColumnName("IS_TOP")
                    .HasColumnType("int(11)")
                    .HasComment("是否置顶，1为是，0为否");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasColumnType("text")
                    .HasComment("标题")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasColumnType("varchar(1)")
                    .HasComment("类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime")
                    .HasComment("更新时间");
            });

            modelBuilder.Entity<NtLabel>(entity =>
            {
                entity.ToTable("nt_label");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("input_user_id")
                    .HasColumnType("int(11)")
                    .HasComment("添加人id");

                entity.Property(e => e.InputUserName)
                    .HasColumnName("input_user_name")
                    .HasColumnType("varchar(128)")
                    .HasComment("添加人姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.InputUserType)
                    .HasColumnName("input_user_type")
                    .HasColumnType("varchar(1)")
                    .HasComment("添加人角色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(128)")
                    .HasComment("标签名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("int(11)")
                    .HasComment("项目id");
            });

            modelBuilder.Entity<NtLearning>(entity =>
            {
                entity.ToTable("nt_learning");

                entity.HasIndex(e => new { e.ProjectId, e.Id })
                    .HasName("get2");

                entity.HasIndex(e => new { e.Province, e.Districtcounty, e.Xian, e.School, e.Type, e.ProjectId })
                    .HasName("get1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .HasComment("id");

                entity.Property(e => e.Discipline)
                    .HasColumnName("discipline")
                    .HasColumnType("varchar(11)")
                    .HasComment("学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("districtcounty")
                    .HasColumnType("varchar(64)")
                    .HasComment("区县")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.EventCount)
                    .HasColumnName("event_count")
                    .HasColumnType("int(11)")
                    .HasComment("发布活动数");

                entity.Property(e => e.ExcellentHomeworks)
                    .HasColumnName("excellent_homeworks")
                    .HasColumnType("int(11)")
                    .HasComment("推荐日志数");

                entity.Property(e => e.InstructorCount)
                    .HasColumnName("instructor_count")
                    .HasColumnType("int(11)")
                    .HasComment("辅导员人数");

                entity.Property(e => e.LoginRate)
                    .HasColumnName("login_rate")
                    .HasColumnType("double(11,2)")
                    .HasComment("登陆率");

                entity.Property(e => e.LoginsCount)
                    .HasColumnName("logins_count")
                    .HasColumnType("int(11)")
                    .HasComment("登陆人数");

                entity.Property(e => e.NoticeCount)
                    .HasColumnName("notice_count")
                    .HasColumnType("int(11)")
                    .HasComment("发布简报数");

                entity.Property(e => e.OnlineTime)
                    .HasColumnName("online_time")
                    .HasColumnType("bigint(30)")
                    .HasComment("在线时长");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("int(11)")
                    .HasComment("项目id");

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasColumnType("varchar(11)")
                    .HasComment("省")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.QualifiedCount)
                    .HasColumnName("qualified_count")
                    .HasColumnType("int(11)")
                    .HasComment("合格人数");

                entity.Property(e => e.QualifiedRate)
                    .HasColumnName("qualified_rate")
                    .HasColumnType("double(11,2)")
                    .HasComment("合格率（网络研修合格率）");

                entity.Property(e => e.ResourceTop)
                    .HasColumnName("resource_top")
                    .HasColumnType("int(11)")
                    .HasComment("推荐资源");

                entity.Property(e => e.School)
                    .HasColumnName("school")
                    .HasColumnType("varchar(64)")
                    .HasComment("学校")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Science)
                    .HasColumnName("SCIENCE")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.SjzyCorrect)
                    .HasColumnName("SJZY_correct")
                    .HasColumnType("int(11)")
                    .HasComment("实践作业批改数");

                entity.Property(e => e.SjzyQualifiedCount)
                    .HasColumnName("SJZY_qualified_count")
                    .HasColumnType("int(11)")
                    .HasComment("实践成绩合格人数");

                entity.Property(e => e.SjzyQualifiedRate)
                    .HasColumnName("SJZY_qualified_rate")
                    .HasColumnType("double(11,2)")
                    .HasComment("实践成绩合格率");

                entity.Property(e => e.SjzyTjcount)
                    .HasColumnName("SJZY_tjcount")
                    .HasColumnType("int(11)")
                    .HasComment("实践作业推荐数");

                entity.Property(e => e.StudyCount)
                    .HasColumnName("study_count")
                    .HasColumnType("int(11)")
                    .HasComment("学习人数（有学分的人数）");

                entity.Property(e => e.StudyRate)
                    .HasColumnName("study_rate")
                    .HasColumnType("double(11,2)")
                    .HasComment("学习率");

                entity.Property(e => e.StudySection)
                    .HasColumnName("STUDY_SECTION")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学段")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("teachinggroup")
                    .HasColumnType("varchar(64)")
                    .HasComment("教研组")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TeachinggtoupId)
                    .HasColumnName("teachinggtoup_id")
                    .HasColumnType("int(11)")
                    .HasComment("教研组id");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(10)")
                    .HasComment("统计类型");

                entity.Property(e => e.UsersCount)
                    .HasColumnName("users_count")
                    .HasColumnType("int(11)")
                    .HasComment("学员数");

                entity.Property(e => e.WeikeTop)
                    .HasColumnName("weike_top")
                    .HasColumnType("int(11)")
                    .HasComment("审阅微课，推荐微课");

                entity.Property(e => e.Workshop)
                    .HasColumnName("workshop")
                    .HasColumnType("varchar(64)")
                    .HasComment("工作坊")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.WorkshopId)
                    .HasColumnName("workshop_id")
                    .HasColumnType("int(11)")
                    .HasComment("工作坊id");

                entity.Property(e => e.Xian)
                    .HasColumnName("xian")
                    .HasColumnType("varchar(64)")
                    .HasComment("县")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<NtMainnum>(entity =>
            {
                entity.ToTable("nt_mainnum");

                entity.HasIndex(e => new { e.Fid, e.Discipline })
                    .HasName("GetByFidAndDiscip");

                entity.HasIndex(e => new { e.Fid, e.LinkStartTime })
                    .HasName("GetByFid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Discipline)
                    .HasColumnName("DISCIPLINE")
                    .HasColumnType("varchar(1024)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fid)
                    .HasColumnName("FId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("input_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InputUserName)
                    .HasColumnName("input_user_name")
                    .HasColumnType("varchar(64)")
                    .HasComment("添加人姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsCopy)
                    .HasColumnName("IS_COPY")
                    .HasColumnType("int(1) unsigned zerofill")
                    .HasComment("是否复制");

                entity.Property(e => e.JoinEvent)
                    .HasColumnType("varchar(1024)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JoinEventIds)
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JoinEventTypes)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JoinTeacherEvent)
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JoinTeacherEventIds)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JoinTeacherEventTypes)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LinkDecription)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LinkEndTime).HasColumnType("datetime");

                entity.Property(e => e.LinkName)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LinkStartTime).HasColumnType("datetime");

                entity.Property(e => e.MainName)
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Requirement)
                    .HasColumnType("text")
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

                entity.Property(e => e.StepCount)
                    .HasColumnName("STEP_COUNT")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TopCount)
                    .HasColumnName("TOP_COUNT")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdateUserName)
                    .HasColumnName("update_user_name")
                    .HasColumnType("varchar(64)")
                    .HasComment("修改人姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtNotice>(entity =>
            {
                entity.ToTable("nt_notice");

                entity.HasIndex(e => new { e.NoticeType, e.Id })
                    .HasName("getNotice");

                entity.HasIndex(e => new { e.NoticeType, e.StartTime, e.EndTime, e.ProjectId })
                    .HasName("get4");

                entity.HasIndex(e => new { e.UserType, e.IsApprovaled, e.NoticeType, e.ProjectId })
                    .HasName("get3");

                entity.HasIndex(e => new { e.IsApprovaled, e.Province, e.Science, e.StudySection, e.Districtcounty, e.Workshop, e.NoticeType, e.ProjectId, e.UserType })
                    .HasName("get1");

                entity.HasIndex(e => new { e.IsApprovaled, e.Province, e.Science, e.StudySection, e.Districtcounty, e.Workshop, e.School, e.Teachinggroup, e.NoticeType, e.ProjectId, e.UserType })
                    .HasName("get2");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdminId)
                    .HasColumnName("ADMIN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApprovalTime)
                    .HasColumnName("APPROVAL_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.BigImg)
                    .HasColumnName("BIG_IMG")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Clicks)
                    .HasColumnName("CLICKS")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("公告简报点赞数");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasColumnType("longtext")
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
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("DISTRICTCOUNTY")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EndTime)
                    .HasColumnName("END_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnterAdminId)
                    .HasColumnName("ENTER_ADMIN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnterTime)
                    .HasColumnName("ENTER_TIME")
                    .HasColumnType("datetime");

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

                entity.Property(e => e.IsCountyTime)
                    .HasColumnName("IS_COUNTY_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsProvince)
                    .HasColumnName("IS_PROVINCE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsProvinceTime)
                    .HasColumnName("IS_PROVINCE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoticeType)
                    .HasColumnName("NOTICE_TYPE")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("ORDER_NUMBER")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrimalSubjectId)
                    .HasColumnName("PRIMAL_SUBJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProgSet)
                    .HasColumnName("PROG_SET")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Province)
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

                entity.Property(e => e.School)
                    .HasColumnName("SCHOOL")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SchoolName)
                    .HasColumnName("SCHOOL_NAME")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Science)
                    .HasColumnName("SCIENCE")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.StudySection)
                    .HasColumnName("STUDY_SECTION")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学段")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Target)
                    .HasColumnName("TARGET")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserType)
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Xian)
                    .HasColumnName("XIAN")
                    .HasColumnType("varchar(11)")
                    .HasComment("县")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtPhaseLearning>(entity =>
            {
                entity.ToTable("nt_phase_learning");

                entity.HasIndex(e => new { e.ProjectId, e.Id })
                    .HasName("get2");

                entity.HasIndex(e => new { e.ProjectId, e.School, e.Type })
                    .HasName("get1");

                entity.HasIndex(e => new { e.ProjectId, e.StudentProjectId, e.Type, e.Id })
                    .HasName("get3");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .HasComment("id");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasColumnType("int(10)")
                    .HasComment("阶段");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("int(11)")
                    .HasComment("项目id");

                entity.Property(e => e.QualifiedCount)
                    .HasColumnName("qualified_count")
                    .HasColumnType("int(11)")
                    .HasComment("合格人数");

                entity.Property(e => e.QualifiedRate)
                    .HasColumnName("qualified_rate")
                    .HasColumnType("double(11,2)")
                    .HasComment("合格率");

                entity.Property(e => e.School)
                    .HasColumnName("school")
                    .HasColumnType("varchar(64)")
                    .HasComment("学校")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.StudentName)
                    .HasColumnName("student_name")
                    .HasColumnType("varchar(64)")
                    .HasComment("姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.StudentProjectId)
                    .HasColumnName("student_project_id")
                    .HasColumnType("int(11)")
                    .HasComment("学员项目id");

                entity.Property(e => e.StudyCount)
                    .HasColumnName("study_count")
                    .HasColumnType("int(11)")
                    .HasComment("学习人数");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(10)")
                    .HasComment("统计类型1:学员，2:学校");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");
            });

            modelBuilder.Entity<NtQuestion>(entity =>
            {
                entity.ToTable("nt_question");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("CONTENT")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QuestionType)
                    .HasColumnName("QUESTION_TYPE")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TestId)
                    .HasColumnName("TEST_ID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NtRequestKeyword>(entity =>
            {
                entity.ToTable("nt_request_keyword");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReferrerUrl)
                    .HasColumnName("Referrer_Url")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RequestDatetime)
                    .HasColumnName("Request_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestForm)
                    .HasColumnName("Request_form")
                    .HasColumnType("varchar(1024)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RequestIp)
                    .HasColumnName("Request_Ip")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RequestUrl)
                    .HasColumnName("Request_Url")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtRoles>(entity =>
            {
                entity.ToTable("nt_roles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EnterAdminId)
                    .HasColumnName("ENTER_ADMIN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnterTime)
                    .HasColumnName("ENTER_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtRolesActions>(entity =>
            {
                entity.ToTable("nt_roles_actions");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActionsId)
                    .HasColumnName("ACTIONS_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnterAdminId)
                    .HasColumnName("ENTER_ADMIN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnterTime)
                    .HasColumnName("ENTER_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Listaction)
                    .HasColumnName("LISTACTION")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Listshow)
                    .HasColumnName("LISTSHOW")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RolesId)
                    .HasColumnName("ROLES_ID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NtTeacherCourse>(entity =>
            {
                entity.ToTable("nt_teacher_course");

                entity.HasIndex(e => e.Id)
                    .HasName("ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveDescription)
                    .HasColumnName("ACTIVE_DESCRIPTION")
                    .HasColumnType("varchar(64)")
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
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BookReview)
                    .HasColumnName("BOOK_REVIEW")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CertificateDescription)
                    .HasColumnName("CERTIFICATE_DESCRIPTION")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CertificateRequery)
                    .HasColumnName("CERTIFICATE_REQUERY")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Clicks)
                    .HasColumnName("CLICKS")
                    .HasColumnType("int(11)");

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

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("DISTRICTCOUNTY")
                    .HasColumnType("varchar(64)")
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
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Host)
                    .HasColumnName("HOST")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsApprovaled)
                    .HasColumnName("IS_APPROVALED")
                    .HasColumnType("varchar(1)")
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

                entity.Property(e => e.IsRecommended)
                    .HasColumnName("IS_RECOMMENDED")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LiveBroadcastTime)
                    .HasColumnName("LIVE_BROADCAST_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.MainRequery)
                    .HasColumnName("MAIN_REQUERY")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("ORDER_NUMBER")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Payment).HasColumnName("PAYMENT");

                entity.Property(e => e.PreTestId)
                    .HasColumnName("PRE_TEST_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrimalSubjectId)
                    .HasColumnName("PRIMAL_SUBJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("Project_id")
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

                entity.Property(e => e.SelectRequery)
                    .HasColumnName("SELECT_REQUERY")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sort)
                    .HasColumnName("sort")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StudyRequery)
                    .HasColumnName("STUDY_REQUERY")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StudySection)
                    .HasColumnName("STUDY_SECTION")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学段")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

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

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TeamTeacher)
                    .HasColumnName("TEAM_TEACHER")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("TEMPLATE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ThirdSubjectId)
                    .HasColumnName("THIRD_SUBJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserName)
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserType)
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WorkDescription)
                    .HasColumnName("WORK_DESCRIPTION")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WorkRequery)
                    .HasColumnName("WORK_REQUERY")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WorkRequirementId)
                    .HasColumnName("WORK_REQUIREMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtTeacherCourseware>(entity =>
            {
                entity.ToTable("nt_teacher_courseware");

                entity.HasIndex(e => e.Id)
                    .HasName("ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cmsid)
                    .HasColumnName("cmsid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CourseId)
                    .HasColumnName("COURSE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CoursewareType)
                    .HasColumnName("COURSEWARE_TYPE")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

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

                entity.Property(e => e.Duration)
                    .HasColumnName("DURATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DurationHours)
                    .HasColumnName("Duration_Hours")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DurationMinutes)
                    .HasColumnName("Duration_Minutes")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DurationSeconds)
                    .HasColumnName("Duration_Seconds")
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

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("ORDER_NUMBER")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecordTime)
                    .HasColumnName("RECORD_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResourseUrl)
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubCollege)
                    .HasColumnName("SUB_COLLEGE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubLecturer)
                    .HasColumnName("SUB_LECTURER")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtTeacherEvent>(entity =>
            {
                entity.ToTable("nt_teacher_event");

                entity.HasIndex(e => e.Id)
                    .HasName("ID");

                entity.HasIndex(e => new { e.ProjectId, e.Districtcounty, e.Province, e.TeacherEventDistinguish })
                    .HasName("get1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdminId)
                    .HasColumnName("ADMIN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BookIds)
                    .HasColumnName("BOOK_IDS")
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BookNames)
                    .HasColumnName("BOOK_NAMES")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Choice)
                    .HasColumnName("CHOICE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClassHour)
                    .HasColumnName("class_hour")
                    .HasComment("学时");

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

                entity.Property(e => e.EnterAdminId)
                    .HasColumnName("ENTER_ADMIN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnterTime)
                    .HasColumnName("ENTER_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventContent)
                    .HasColumnName("EVENT_CONTENT")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EventHarvest)
                    .HasColumnName("Event_harvest")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EventLimit)
                    .HasColumnName("EVENT_LIMIT")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EventTime)
                    .HasColumnName("EVENT_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventTimeEnd)
                    .HasColumnName("EVENT_TIME_End")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .HasColumnName("EVENT_TYPE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExpertTop)
                    .HasColumnName("EXPERT_TOP")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HeadImgUrl)
                    .HasColumnName("HEAD_IMG_URL")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsApprovaled)
                    .HasColumnName("IS_APPROVALED")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MainNum)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NumberOfPeople)
                    .HasColumnName("NUMBER_OF_PEOPLE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParticipantCount)
                    .HasColumnName("participantCount")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Path)
                    .HasColumnName("PATH")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Promote)
                    .HasColumnName("PROMOTE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Province)
                    .HasColumnName("PROVINCE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResultExcelPath)
                    .HasColumnName("Result_excel_path")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResultImagePath)
                    .HasColumnName("Result_image_path")
                    .HasColumnType("varchar(200)")
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

                entity.Property(e => e.Sort)
                    .HasColumnName("sort")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StudySection)
                    .HasColumnName("STUDY_SECTION")
                    .HasColumnType("varchar(128)")
                    .HasComment("新学段")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TeacherEventDistinguish)
                    .HasColumnName("TEACHER_EVENT_DISTINGUISH")
                    .HasColumnType("varchar(1)")
                    .HasComment("1为班级研修活动（原来线下活动） 0为线上活动 2为作业管理 3线下活动展示 4线下活动")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TestId)
                    .HasColumnName("TEST_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserName)
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserType)
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Weikeurl)
                    .HasColumnName("WEIKEURL")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Xian)
                    .HasColumnName("xian")
                    .HasColumnType("varchar(30)")
                    .HasComment("县")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtTeacherEventMainnum>(entity =>
            {
                entity.ToTable("nt_teacher_event_mainnum");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

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

                entity.Property(e => e.FromDiscipline)
                    .HasColumnName("FromDISCIPLINE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromDistrictcounty)
                    .HasColumnName("FromDISTRICTCOUNTY")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromProvince)
                    .HasColumnName("FromPROVINCE")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromSchool)
                    .HasColumnName("FromSCHOOL")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromScience)
                    .HasColumnName("FromSCIENCE")
                    .HasColumnType("varchar(128)")
                    .HasComment("匹配坊的学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.FromStudySection)
                    .HasColumnName("FromSTUDY_SECTION")
                    .HasColumnType("varchar(128)")
                    .HasComment("匹配坊的学段")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.FromTeachinggroup)
                    .HasColumnName("FromTEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromType).HasColumnType("int(11)");

                entity.Property(e => e.FromWorkshop)
                    .HasColumnName("FromWORKSHOP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LinkName)
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MainName)
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MainNumId)
                    .HasColumnName("MainNumID")
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
                    .HasComment("被匹配坊的学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.StudySection)
                    .HasColumnName("STUDY_SECTION")
                    .HasColumnType("varchar(128)")
                    .HasComment("被匹配坊的学段")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TeacherEventId)
                    .HasColumnName("TeacherEventID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TeacherEventName)
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TeacherEventType)
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtTest>(entity =>
            {
                entity.ToTable("nt_test");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdminId)
                    .HasColumnName("ADMIN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Answers)
                    .HasColumnName("ANSWERS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApprovaleTime)
                    .HasColumnName("APPROVALE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
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

                entity.Property(e => e.IsApprovaled)
                    .HasColumnName("IS_APPROVALED")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsStudentPermit)
                    .HasColumnName("IS_STUDENT_PERMIT")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsUsed)
                    .HasColumnName("IS_USED")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

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

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NtTheme>(entity =>
            {
                entity.ToTable("nt_theme");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdminTop)
                    .HasColumnName("admin_top")
                    .HasColumnType("int(11)")
                    .HasComment("管理员置顶");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("int(11)")
                    .HasComment("评论数");

                entity.Property(e => e.Content)
                    .HasColumnType("varchar(1024)")
                    .HasComment("内容")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Discipline)
                    .HasColumnName("DISCIPLINE")
                    .HasColumnType("varchar(128)")
                    .HasComment("学科")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("DISTRICTCOUNTY")
                    .HasColumnType("varchar(128)")
                    .HasComment("区县")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ImgPath)
                    .HasColumnName("Img_path")
                    .HasColumnType("varchar(1024)")
                    .HasComment("图片路径（多路径用,分隔）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.InputUserHeadimg)
                    .HasColumnName("input_user_headimg")
                    .HasColumnType("varchar(512)")
                    .HasComment("添加人头像路径")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("input_user_id")
                    .HasColumnType("int(11)")
                    .HasComment("添加人id");

                entity.Property(e => e.InputUserName)
                    .HasColumnName("input_user_name")
                    .HasColumnType("varchar(128)")
                    .HasComment("添加人姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.InputUserType)
                    .HasColumnName("input_user_type")
                    .HasColumnType("varchar(1)")
                    .HasComment("添加人角色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("is_approved")
                    .HasColumnType("varchar(1)")
                    .HasComment("是否审核1审核0未审核")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasColumnType("varchar(1)")
                    .HasComment("是否删除1删除0未删除")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Label)
                    .HasColumnType("varchar(1024)")
                    .HasComment("标签(多标签用,分隔)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Likes)
                    .HasColumnName("likes")
                    .HasColumnType("int(11)")
                    .HasComment("点赞数");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("int(11)")
                    .HasComment("项目id");

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasColumnType("varchar(128)")
                    .HasComment("省")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.School)
                    .HasColumnName("SCHOOL")
                    .HasColumnType("varchar(128)")
                    .HasComment("学校")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(128)")
                    .HasComment("教研组")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(512)")
                    .HasComment("标题")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(11)")
                    .HasComment("话题类型");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(128)")
                    .HasComment("工作坊")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<NtUserLabel>(entity =>
            {
                entity.ToTable("nt_user_label");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("input_user_id")
                    .HasColumnType("int(11)")
                    .HasComment("添加人id");

                entity.Property(e => e.InputUserName)
                    .HasColumnName("input_user_name")
                    .HasColumnType("varchar(128)")
                    .HasComment("添加人姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.InputUserType)
                    .HasColumnName("input_user_type")
                    .HasColumnType("varchar(1)")
                    .HasComment("添加人角色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.LabelId)
                    .HasColumnName("label_id")
                    .HasColumnType("int(11)")
                    .HasComment("标签id");

                entity.Property(e => e.LabelName)
                    .HasColumnName("label_name")
                    .HasColumnType("varchar(128)")
                    .HasComment("标签名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("int(11)")
                    .HasComment("项目id");
            });

            modelBuilder.Entity<NtUsersRoles>(entity =>
            {
                entity.ToTable("nt_users_roles");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnterAdminId)
                    .HasColumnName("ENTER_ADMIN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnterTime)
                    .HasColumnName("ENTER_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.RolesId)
                    .HasColumnName("ROLES_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsersId)
                    .HasColumnName("USERS_ID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NtWindow>(entity =>
            {
                entity.ToTable("nt_window");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdminId)
                    .HasColumnName("ADMIN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApprovalTime)
                    .HasColumnName("APPROVAL_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Clicks)
                    .HasColumnName("CLICKS")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

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
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.District)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("DISTRICTCOUNTY")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EndTime)
                    .HasColumnName("END_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnterAdminId)
                    .HasColumnName("ENTER_ADMIN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnterTime)
                    .HasColumnName("ENTER_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Images)
                    .IsRequired()
                    .HasColumnName("images")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

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

                entity.Property(e => e.IsCountyTime)
                    .HasColumnName("IS_COUNTY_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsProvince)
                    .HasColumnName("IS_PROVINCE")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsProvinceTime)
                    .HasColumnName("IS_PROVINCE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Istop)
                    .HasColumnName("istop")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否置顶")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("ORDER_NUMBER")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrimalSubjectId)
                    .HasColumnName("PRIMAL_SUBJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProgSet)
                    .HasColumnName("PROG_SET")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Province)
                    .HasColumnType("varchar(1024)")
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

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Target)
                    .HasColumnName("TARGET")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TopTime)
                    .HasColumnName("top_time")
                    .HasColumnType("datetime")
                    .HasComment("置顶时间");

                entity.Property(e => e.UserType)
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WindowType)
                    .HasColumnName("window_TYPE")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ntv2Attribute>(entity =>
            {
                entity.ToTable("ntv2_attribute");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(256)")
                    .HasComment("描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.DictionaryType)
                    .HasColumnName("dictionary_type")
                    .HasColumnType("int(11)")
                    .HasComment("1分类2维度3报告类");

                entity.Property(e => e.FId)
                    .HasColumnName("f_id")
                    .HasColumnType("int(11)")
                    .HasComment("上级id");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("input_user_id")
                    .HasColumnType("int(11)")
                    .HasComment("添加人id");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasColumnType("int(11)")
                    .HasComment("排序");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("int(11)")
                    .HasComment("项目id");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)")
                    .HasComment("修改人id");

                entity.Property(e => e.VKey)
                    .HasColumnName("v_key")
                    .HasColumnType("varchar(64)")
                    .HasComment("键")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.VValue)
                    .HasColumnName("v_value")
                    .HasColumnType("varchar(64)")
                    .HasComment("值")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Ntv2CourseTopic>(entity =>
            {
                entity.ToTable("ntv2_course_topic");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .HasComment("id");

                entity.Property(e => e.ClassHour)
                    .HasColumnName("class_hour")
                    .HasComment("学时");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("text")
                    .HasComment("主题简介")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Fid)
                    .HasColumnName("FId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("父级");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("input_user_id")
                    .HasColumnType("int(11)")
                    .HasComment("添加人id");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(256)")
                    .HasComment("主题名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("int(11)")
                    .HasComment("项目id");

                entity.Property(e => e.SubordinateId)
                    .HasColumnName("subordinate_id")
                    .HasColumnType("int(11)")
                    .HasComment("从属id，维度id");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)")
                    .HasComment("修改人id");
            });

            modelBuilder.Entity<Ntv2CoursetopicCourse>(entity =>
            {
                entity.ToTable("ntv2_coursetopic_course");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .HasComment("id");

                entity.Property(e => e.ClassHour)
                    .HasColumnName("class_hour")
                    .HasDefaultValueSql("'0'")
                    .HasComment("学时");

                entity.Property(e => e.ClassTopicId)
                    .HasColumnName("ClassTopic_id")
                    .HasColumnType("int(11)")
                    .HasComment("课程主题id");

                entity.Property(e => e.CourseJoinType)
                    .HasColumnName("course_join_type")
                    .HasColumnType("int(11)")
                    .HasComment("关联类型1为课程，2为文本课程，3为作业");

                entity.Property(e => e.DataId)
                    .HasColumnName("data_id")
                    .HasColumnType("int(11)")
                    .HasComment("关联id");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("input_user_id")
                    .HasColumnType("int(11)")
                    .HasComment("添加人id");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasColumnType("int(11)")
                    .HasComment("排序");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)")
                    .HasComment("修改人id");
            });

            modelBuilder.Entity<Ntv2EventCourse>(entity =>
            {
                entity.ToTable("ntv2_event_course");

                entity.HasIndex(e => e.Type)
                    .HasName("byType");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdminId)
                    .HasColumnName("ADMIN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BookIds)
                    .HasColumnName("BOOK_IDS")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BookNames)
                    .HasColumnName("BOOK_NAMES")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClassHour)
                    .HasColumnName("class_hour")
                    .HasComment("学时");

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

                entity.Property(e => e.EnterAdminId)
                    .HasColumnName("ENTER_ADMIN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnterTime)
                    .HasColumnName("ENTER_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventContent)
                    .HasColumnName("EVENT_CONTENT")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EventHarvest)
                    .HasColumnName("Event_harvest")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EventLimit)
                    .HasColumnName("EVENT_LIMIT")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EventTime)
                    .HasColumnName("EVENT_TIME")
                    .HasColumnType("date");

                entity.Property(e => e.EventTimeEnd)
                    .HasColumnName("EVENT_TIME_End")
                    .HasColumnType("date");

                entity.Property(e => e.EventType)
                    .HasColumnName("EVENT_TYPE")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HeadImgUrl)
                    .HasColumnName("HEAD_IMG_URL")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsApprovaled)
                    .HasColumnName("IS_APPROVALED")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsCopy)
                    .HasColumnName("IS_COPY")
                    .HasColumnType("int(1) unsigned zerofill")
                    .HasComment("是否复制");

                entity.Property(e => e.IsMainnumEvent)
                    .HasColumnName("IS_MAINNUM_EVENT")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NumberOfPeople)
                    .HasColumnName("NUMBER_OF_PEOPLE")
                    .HasColumnType("int(11)");

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

                entity.Property(e => e.Sort)
                    .HasColumnName("sort")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StandardChaptersNum)
                    .HasColumnName("standard_Chapters_num")
                    .HasColumnType("int(11)")
                    .HasComment("达标章节数");

                entity.Property(e => e.StudentName)
                    .HasColumnName("Student_name")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Teachinggroup)
                    .HasColumnName("TEACHINGGROUP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TestId)
                    .HasColumnName("TEST_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnName("WORKSHOP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ntv2IntegralRules>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ValueType })
                    .HasName("PRIMARY");

                entity.ToTable("ntv2_integral_rules");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ValueType)
                    .HasColumnName("value_type")
                    .HasColumnType("int(11)")
                    .HasComment("值类型，1为分值，2为组合包");

                entity.Property(e => e.DataId)
                    .HasColumnName("data_id")
                    .HasColumnType("int(11)")
                    .HasComment("关联id，阶段id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(64)")
                    .HasComment("描述,用于标识加分项的中文释义")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.FId)
                    .HasColumnName("f_id")
                    .HasColumnType("int(11)")
                    .HasComment("上级id");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.InputUserId)
                    .HasColumnName("input_user_id")
                    .HasColumnType("int(11)")
                    .HasComment("添加人id");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasColumnType("int(11)")
                    .HasComment("排序");

                entity.Property(e => e.PackValues)
                    .HasColumnName("pack_values")
                    .HasColumnType("varchar(256)")
                    .HasComment("组合包，用于合并计算项，和自定义类型合格标准")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("int(11)")
                    .HasComment("项目id");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(256)")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.RulesType)
                    .HasColumnName("rules_type")
                    .HasColumnType("int(11)")
                    .HasComment("类型,1为学分规则，2为主线各阶段合格标准");

                entity.Property(e => e.TotalScoreType)
                    .HasColumnName("total_score_type")
                    .HasColumnType("int(11)")
                    .HasComment("总分类型，1是在总分内，2不计算总分内");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)")
                    .HasComment("修改人id");

                entity.Property(e => e.UserType)
                    .HasColumnName("user_type")
                    .HasColumnType("varchar(256)")
                    .HasComment(@"区分用户身份的学分标准
")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.VKey)
                    .HasColumnName("v_key")
                    .HasColumnType("varchar(64)")
                    .HasComment("键")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.VValue)
                    .HasColumnName("v_value")
                    .HasComment("值");

                entity.Property(e => e.ValueLimit)
                    .HasColumnName("value_limit")
                    .HasComment("上限分值");

                entity.Property(e => e.ValueQualified)
                    .HasColumnName("value_qualified")
                    .HasComment("及格分值");
            });

            modelBuilder.Entity<Ntv2LogRecord>(entity =>
            {
                entity.ToTable("ntv2_log_record");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime")
                    .HasComment("操作时间");

                entity.Property(e => e.OperationDataid)
                    .HasColumnName("operation_dataid")
                    .HasColumnType("int(11)")
                    .HasComment("操作数据的关联id");

                entity.Property(e => e.OperationFunction)
                    .HasColumnName("operation_function")
                    .HasColumnType("varchar(256)")
                    .HasComment("操作函数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.OperationType)
                    .HasColumnName("operation_type")
                    .HasColumnType("int(11)")
                    .HasComment("操作类型（1增加，2删除，3修改）");

                entity.Property(e => e.OperationUserid)
                    .HasColumnName("operation_userid")
                    .HasColumnType("int(11)")
                    .HasComment("操作人id");

                entity.Property(e => e.OperdtionUsername)
                    .HasColumnName("operdtion_username")
                    .HasColumnType("varchar(255)")
                    .HasComment("操作员姓名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("int(11)")
                    .HasComment("项目id");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasColumnType("mediumtext")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Ntv2MasterSlave>(entity =>
            {
                entity.ToTable("ntv2_master_slave");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Dataids)
                    .HasColumnName("DATAIDS")
                    .HasColumnType("varchar(256)")
                    .HasComment("所选(维度/课程包)ids")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Datatype)
                    .HasColumnName("DATATYPE")
                    .HasColumnType("varchar(1)")
                    .HasComment("数据类型：1分类，2课程包")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Districtcounty)
                    .HasColumnName("DISTRICTCOUNTY")
                    .HasColumnType("varchar(64)")
                    .HasComment("区县")
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

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("int(11)")
                    .HasComment("项目id");

                entity.Property(e => e.Province)
                    .HasColumnName("PROVINCE")
                    .HasColumnType("varchar(64)")
                    .HasComment("省")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.SchoolName)
                    .HasColumnName("schoolName")
                    .HasColumnType("varchar(128)")
                    .HasComment("学校名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.StudentprojectId)
                    .HasColumnName("studentproject_id")
                    .HasColumnType("int(11)")
                    .HasComment("学员id");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.UpdateUserId)
                    .HasColumnName("update_user_id")
                    .HasColumnType("int(11)")
                    .HasComment("修改人id");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)")
                    .HasComment("用户id");

                entity.Property(e => e.UserType)
                    .HasColumnName("user_type")
                    .HasColumnType("varchar(1)")
                    .HasComment("参加项目角色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Xian)
                    .HasColumnName("XIAN")
                    .HasColumnType("varchar(11)")
                    .HasComment("县")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Sequence>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sequence");

                entity.Property(e => e.Seq)
                    .HasColumnName("seq")
                    .HasColumnType("int(3)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
