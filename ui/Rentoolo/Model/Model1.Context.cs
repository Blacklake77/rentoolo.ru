﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentoolo.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RentooloEntities : DbContext
    {
        public RentooloEntities()
            : base("name=RentooloEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adverts> Adverts { get; set; }
        public virtual DbSet<Applications> Applications { get; set; }
        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<AuctionRequests> AuctionRequests { get; set; }
        public virtual DbSet<Auctions> Auctions { get; set; }
        public virtual DbSet<Business> Business { get; set; }
        public virtual DbSet<CashIns> CashIns { get; set; }
        public virtual DbSet<CashOuts> CashOuts { get; set; }
        public virtual DbSet<ChatActiveUsers> ChatActiveUsers { get; set; }
        public virtual DbSet<ChatMessages> ChatMessages { get; set; }
        public virtual DbSet<Chats> Chats { get; set; }
        public virtual DbSet<ChatUsers> ChatUsers { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Complaints> Complaints { get; set; }
        public virtual DbSet<CraftsMan> CraftsMan { get; set; }
        public virtual DbSet<CraftsManOrder> CraftsManOrder { get; set; }
        public virtual DbSet<Currencies> Currencies { get; set; }
        public virtual DbSet<DailyStatistics> DailyStatistics { get; set; }
        public virtual DbSet<DeletedAdverts> DeletedAdverts { get; set; }
        public virtual DbSet<DialogActiveUsers> DialogActiveUsers { get; set; }
        public virtual DbSet<DialogMessages> DialogMessages { get; set; }
        public virtual DbSet<DialogsInfo> DialogsInfo { get; set; }
        public virtual DbSet<DisLikes> DisLikes { get; set; }
        public virtual DbSet<Exceptions> Exceptions { get; set; }
        public virtual DbSet<ExchangeItemRequests> ExchangeItemRequests { get; set; }
        public virtual DbSet<ExchangeProducts> ExchangeProducts { get; set; }
        public virtual DbSet<Favorites> Favorites { get; set; }
        public virtual DbSet<FavoritesByCookies> FavoritesByCookies { get; set; }
        public virtual DbSet<ItemDislikes> ItemDislikes { get; set; }
        public virtual DbSet<ItemLikes> ItemLikes { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Likes> Likes { get; set; }
        public virtual DbSet<LoginStat> LoginStat { get; set; }
        public virtual DbSet<LoginStatistics> LoginStatistics { get; set; }
        public virtual DbSet<Memberships> Memberships { get; set; }
        public virtual DbSet<NewAezakmi> NewAezakmi { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<News_towardsbackwards> News_towardsbackwards { get; set; }
        public virtual DbSet<NewsAlexPigalyov> NewsAlexPigalyov { get; set; }
        public virtual DbSet<NewsAntares> NewsAntares { get; set; }
        public virtual DbSet<NewsAzizjan> NewsAzizjan { get; set; }
        public virtual DbSet<NewsBatrebleSs> NewsBatrebleSs { get; set; }
        public virtual DbSet<NewsEducation> NewsEducation { get; set; }
        public virtual DbSet<NewsEoll73> NewsEoll73 { get; set; }
        public virtual DbSet<NewsGGdotNET> NewsGGdotNET { get; set; }
        public virtual DbSet<Newsillfyar> Newsillfyar { get; set; }
        public virtual DbSet<NewsIlya> NewsIlya { get; set; }
        public virtual DbSet<NewsMrshkVV> NewsMrshkVV { get; set; }
        public virtual DbSet<NewsRaspel> NewsRaspel { get; set; }
        public virtual DbSet<NewsVark> NewsVark { get; set; }
        public virtual DbSet<NewsVlad> NewsVlad { get; set; }
        public virtual DbSet<Operations> Operations { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Phones> Phones { get; set; }
        public virtual DbSet<Rates> Rates { get; set; }
        public virtual DbSet<Recipes> Recipes { get; set; }
        public virtual DbSet<Referrals> Referrals { get; set; }
        public virtual DbSet<Rent> Rent { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<TenderRequest> TenderRequest { get; set; }
        public virtual DbSet<Tenders> Tenders { get; set; }
        public virtual DbSet<TokensBuying> TokensBuying { get; set; }
        public virtual DbSet<TokensCost> TokensCost { get; set; }
        public virtual DbSet<TokensSelling> TokensSelling { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserSettings> UserSettings { get; set; }
        public virtual DbSet<UsersOpenAuthAccounts> UsersOpenAuthAccounts { get; set; }
        public virtual DbSet<UsersOpenAuthData> UsersOpenAuthData { get; set; }
        public virtual DbSet<UsersSearches> UsersSearches { get; set; }
        public virtual DbSet<UserViews> UserViews { get; set; }
        public virtual DbSet<ViewedObjects> ViewedObjects { get; set; }
        public virtual DbSet<Wallets> Wallets { get; set; }
        public virtual DbSet<Watched> Watched { get; set; }
        public virtual DbSet<WatchedByCookies> WatchedByCookies { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<NewsShCodder> NewsShCodder { get; set; }
        public virtual DbSet<RentedTime> RentedTime { get; set; }
        public virtual DbSet<GeographyDPD> GeographyDPD { get; set; }
    
        [DbFunction("RentooloEntities", "fnGetAllUsers")]
        public virtual IQueryable<fnGetAllUsers_Result> fnGetAllUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fnGetAllUsers_Result>("[RentooloEntities].[fnGetAllUsers]()");
        }
    
        [DbFunction("RentooloEntities", "fnGetTablesRows")]
        public virtual IQueryable<fnGetTablesRows_Result> fnGetTablesRows()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fnGetTablesRows_Result>("[RentooloEntities].[fnGetTablesRows]()");
        }
    
        [DbFunction("RentooloEntities", "fnGetUserReferralsSecondLevel")]
        public virtual IQueryable<fnGetUserReferralsSecondLevel_Result> fnGetUserReferralsSecondLevel(Nullable<System.Guid> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fnGetUserReferralsSecondLevel_Result>("[RentooloEntities].[fnGetUserReferralsSecondLevel](@userId)", userIdParameter);
        }
    
        [DbFunction("RentooloEntities", "fnGetUserReferralsThirdLevel")]
        public virtual IQueryable<fnGetUserReferralsThirdLevel_Result> fnGetUserReferralsThirdLevel(Nullable<System.Guid> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fnGetUserReferralsThirdLevel_Result>("[RentooloEntities].[fnGetUserReferralsThirdLevel](@userId)", userIdParameter);
        }
    
        [DbFunction("RentooloEntities", "fnGetUserWallets")]
        public virtual IQueryable<fnGetUserWallets_Result> fnGetUserWallets(Nullable<System.Guid> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fnGetUserWallets_Result>("[RentooloEntities].[fnGetUserWallets](@userId)", userIdParameter);
        }
    
        public virtual int spAddAdvert(Nullable<int> category, string name, string description, Nullable<System.Guid> createdUserId, Nullable<double> price, string address, string phone, Nullable<int> messageType, System.Data.Entity.Spatial.DbGeography position, string imgUrls, string youTubeUrl)
        {
            var categoryParameter = category.HasValue ?
                new ObjectParameter("Category", category) :
                new ObjectParameter("Category", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var createdUserIdParameter = createdUserId.HasValue ?
                new ObjectParameter("CreatedUserId", createdUserId) :
                new ObjectParameter("CreatedUserId", typeof(System.Guid));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(double));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var messageTypeParameter = messageType.HasValue ?
                new ObjectParameter("MessageType", messageType) :
                new ObjectParameter("MessageType", typeof(int));
    
            var positionParameter = position != null ?
                new ObjectParameter("Position", position) :
                new ObjectParameter("Position", typeof(System.Data.Entity.Spatial.DbGeography));
    
            var imgUrlsParameter = imgUrls != null ?
                new ObjectParameter("ImgUrls", imgUrls) :
                new ObjectParameter("ImgUrls", typeof(string));
    
            var youTubeUrlParameter = youTubeUrl != null ?
                new ObjectParameter("YouTubeUrl", youTubeUrl) :
                new ObjectParameter("YouTubeUrl", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddAdvert", categoryParameter, nameParameter, descriptionParameter, createdUserIdParameter, priceParameter, addressParameter, phoneParameter, messageTypeParameter, positionParameter, imgUrlsParameter, youTubeUrlParameter);
        }
    
        public virtual int spAddFavorites(Nullable<System.Guid> userId, Nullable<long> advertId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(System.Guid));
    
            var advertIdParameter = advertId.HasValue ?
                new ObjectParameter("advertId", advertId) :
                new ObjectParameter("advertId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddFavorites", userIdParameter, advertIdParameter);
        }
    
        public virtual int spAddFavoritesByCookies(string uid, Nullable<long> advertId)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            var advertIdParameter = advertId.HasValue ?
                new ObjectParameter("advertId", advertId) :
                new ObjectParameter("advertId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddFavoritesByCookies", uidParameter, advertIdParameter);
        }
    
        public virtual int spAddWatched(Nullable<System.Guid> userId, Nullable<long> advertId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(System.Guid));
    
            var advertIdParameter = advertId.HasValue ?
                new ObjectParameter("advertId", advertId) :
                new ObjectParameter("advertId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddWatched", userIdParameter, advertIdParameter);
        }
    
        public virtual int spAddWatchedByCookies(string uid, Nullable<long> advertId)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            var advertIdParameter = advertId.HasValue ?
                new ObjectParameter("advertId", advertId) :
                new ObjectParameter("advertId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddWatchedByCookies", uidParameter, advertIdParameter);
        }
    
        public virtual ObjectResult<spGetChats_Result> spGetChats(Nullable<System.Guid> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetChats_Result>("spGetChats", userIdParameter);
        }
    
        public virtual ObjectResult<spGetChatsForUser_Result> spGetChatsForUser(Nullable<System.Guid> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetChatsForUser_Result>("spGetChatsForUser", userIdParameter);
        }
    
        public virtual ObjectResult<spGetComments_Result> spGetComments(Nullable<long> objectId, Nullable<System.Guid> userId)
        {
            var objectIdParameter = objectId.HasValue ?
                new ObjectParameter("objectId", objectId) :
                new ObjectParameter("objectId", typeof(long));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetComments_Result>("spGetComments", objectIdParameter, userIdParameter);
        }
    
        public virtual ObjectResult<spGetCommentsForUser_Result> spGetCommentsForUser(Nullable<System.Guid> userId, Nullable<int> advertId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(System.Guid));
    
            var advertIdParameter = advertId.HasValue ?
                new ObjectParameter("advertId", advertId) :
                new ObjectParameter("advertId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetCommentsForUser_Result>("spGetCommentsForUser", userIdParameter, advertIdParameter);
        }
    
        public virtual ObjectResult<spGetComplaintsByRecipier_Result> spGetComplaintsByRecipier(Nullable<System.Guid> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetComplaintsByRecipier_Result>("spGetComplaintsByRecipier", userIdParameter);
        }
    
        public virtual ObjectResult<spGetComplaintsBySender_Result> spGetComplaintsBySender(Nullable<System.Guid> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetComplaintsBySender_Result>("spGetComplaintsBySender", userIdParameter);
        }
    
        public virtual ObjectResult<spGetExchangeItemRequests_Result> spGetExchangeItemRequests(Nullable<long> exchangeItemId)
        {
            var exchangeItemIdParameter = exchangeItemId.HasValue ?
                new ObjectParameter("exchangeItemId", exchangeItemId) :
                new ObjectParameter("exchangeItemId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetExchangeItemRequests_Result>("spGetExchangeItemRequests", exchangeItemIdParameter);
        }
    
        public virtual ObjectResult<spGetExchangeProducts_Result> spGetExchangeProducts(string query)
        {
            var queryParameter = query != null ?
                new ObjectParameter("query", query) :
                new ObjectParameter("query", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetExchangeProducts_Result>("spGetExchangeProducts", queryParameter);
        }
    
        public virtual ObjectResult<spGetFavorites_Result> spGetFavorites(Nullable<System.Guid> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetFavorites_Result>("spGetFavorites", userIdParameter);
        }
    
        public virtual ObjectResult<spGetFavoritesByCookies_Result> spGetFavoritesByCookies(string uid)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetFavoritesByCookies_Result>("spGetFavoritesByCookies", uidParameter);
        }
    
        public virtual ObjectResult<spGetLast200TokensOperations_Result> spGetLast200TokensOperations()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetLast200TokensOperations_Result>("spGetLast200TokensOperations");
        }
    
        public virtual int spGetLoginStatisticLastDayActive()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spGetLoginStatisticLastDayActive");
        }
    
        public virtual int spGetLoginStatisticLastHourActive()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spGetLoginStatisticLastHourActive");
        }
    
        public virtual ObjectResult<spGetTokenCostToday_Result> spGetTokenCostToday()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetTokenCostToday_Result>("spGetTokenCostToday");
        }
    
        public virtual ObjectResult<spGetUserAdverts_Result> spGetUserAdverts(Nullable<System.Guid> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetUserAdverts_Result>("spGetUserAdverts", userIdParameter);
        }
    
        public virtual ObjectResult<spGetWatched_Result> spGetWatched(Nullable<System.Guid> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetWatched_Result>("spGetWatched", userIdParameter);
        }
    
        public virtual ObjectResult<spGetWatchedByCookies_Result> spGetWatchedByCookies(string uid)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetWatchedByCookies_Result>("spGetWatchedByCookies", uidParameter);
        }
    
        public virtual ObjectResult<spGeographyDPDTop10_Result> spGeographyDPDTop10(string text)
        {
            var textParameter = text != null ?
                new ObjectParameter("text", text) :
                new ObjectParameter("text", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGeographyDPDTop10_Result>("spGeographyDPDTop10", textParameter);
        }
    }
}
