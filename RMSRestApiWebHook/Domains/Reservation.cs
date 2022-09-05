
namespace RMSRestApiWebHook.Domain;

    public class Reservation
    {
        public int ReservationId { get; set; }
        public int ActivityId { get; set; }
        public string? AreaName { get; set; }
        public string? Billing { get; set; }
        public int BoatId { get; set; }
        public int BookerContactId { get; set; }
        public int BusinessLostId { get; set; }
        public int BusinessSegmentId { get; set; }
        public int CancellationPolicyId { get; set; }
        public int CancelledById { get; set; }
        public string? CardNumber { get; set; }
        public string? CategoryName { get; set; }
        public int ContactId { get; set; }
        public int ConfirmedById { get; set; }
        public DateTime ConfirmedDate { get; set; }
        public int Coordinator1Id { get; set; }
        public int Coordinator2Id { get; set; }
        public DateTime CreatedDate { get; set; }   //date
        public int CreatedById { get; set; }
        public int DestinationCodeId { get; set; }
        public int DiscountId { get; set; }
        public string? Eta { get; set; }     //date
        public string? EventName { get; set; }
        public DateTime EventFinish { get; set; }
        public DateTime EventStart { get; set; }
        public string? Attendees { get; set; }
        public string? ExternalCancelId { get; set; }
        public string? ExternalResId { get; set; }
        public bool FixedRes { get; set; }
        public int FixedResReasonId { get; set; }
        public bool GroupHeader { get; set; }
        public string? GuestGiven { get; set; }
        public string? GuestSurname { get; set; }
        public bool LongTerm { get; set; }
        public DateTime ModifiedDate { get; set; } //date
        public int ModifiedById { get; set; }
        public int MealPlanId { get; set; }
        public int OccupantId { get; set; }
        public int OriginId { get; set; }
        public string? OtaNotes { get; set; }
        public string? OtaRef1 { get; set; }
        public string? OtaRef2 { get; set; }
        public string? OtaRef3 { get; set; }
        public int PaymentModeId { get; set; }
        public bool PosOnGroupMaster { get; set; }
        public float PreAuthAmount { get; set; }  //decimal
        public string? PreAuthCode { get; set; }
        public DateTime PreAuthExpDate { get; set; }  //date
        public int PropertyId { get; set; }
        public bool RateOnGroup { get; set; }
        public string? ReservationType { get; set; }
        public int SplitResId { get; set; }
        public int SubResTypeId { get; set; }
        public string? TravelAgentName { get; set; }
        public int Adults { get; set; }
        public string? BookingSourceName { get; set; }
        public int BookingSourceId { get; set; }
        public int Children { get; set; }
        public int CompanyId { get; set; }
        public int GroupAllotmentId { get; set; }
        public int GroupReservationId { get; set; }
        public int Infants { get; set; }
        public int MarketSegmentId { get; set; }
        public string? Notes { get; set; }
        public int OnlineConfirmationId { get; set; }
        public int ResTypeId { get; set; }
        public int SubMarketSegmentId { get; set; }
        public int TravelAgentId { get; set; }
        public string? UserDefined1 { get; set; }
        public string? UserDefined2 { get; set; }
        public string? UserDefined3 { get; set; }
        public string? UserDefined4 { get; set; }
        public string? UserDefined5 { get; set; }
        public string? UserDefined6 { get; set; }
        public string? UserDefined7 { get; set; }
        public string? UserDefined8 { get; set; }
        public string? UserDefined9 { get; set; }
        public string? UserDefined10 { get; set; }
        public string? UserDefined11 { get; set; }
        public string? UserDefined12 { get; set; }
        public string? UserDefined13 { get; set; }
        public string? UserDefined14 { get; set; }
        public string? UserDefined15 { get; set; }
        public string? VoucherId { get; set; }
        public int WholesalerId { get; set; }
        public int AccountId { get; set; }
        public int AreaId { get; set; }
        public DateTime ArrivalDate { get; set; }  //date
        public DateTime CancelledDate { get; set; }  //date
        public DateTime DepartureDate { get; set; }  //date
        public int GuestId { get; set; }
        public int RateTypeId { get; set; }
        public int CategoryId { get; set; }
        public string? RateTypeName { get; set; }
        public string? Status { get; set; }

    }

