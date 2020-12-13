﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChellengeTwo.Repo
{
    public class ClaimRepo
    {
        private Queue<ClaimContent> _claimContents = new Queue<ClaimContent>();

        //create
        public void AddClaim(ClaimContent content)
        {
            _claimContents.Enqueue(content);
        }

        //read
        public Queue<ClaimContent> GetClaimContents()
        {
            return _claimContents;
        }

        //update
        public bool UpdateClaimData(int originalClaimID, ClaimContent newClaimContent)
        {
            ClaimContent oldClaimContent = GetClaimById(originalClaimID);

            if (oldClaimContent != null)
            {
                oldClaimContent.ClaimID = newClaimContent.ClaimID;
                oldClaimContent.ClaimType = newClaimContent.ClaimType;
                oldClaimContent.Description = newClaimContent.Description;
                oldClaimContent.ClaimAmount = newClaimContent.ClaimAmount;
                oldClaimContent.DateOfIncident = newClaimContent.DateOfIncident;
                oldClaimContent.DateOfClaim = newClaimContent.DateOfClaim;
                oldClaimContent.IsValid = newClaimContent.IsValid;
                return true;
            }
            else
            {
                return false;
            }

            int initialCount = _claimContents.Count;
            _claimContents.Dequeue();

            if (initialCount > _claimContents.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //delete
        public bool RemoveClaimContent(int claimID)
        {
            ClaimContent claimContent = GetClaimById(claimID);

            if (claimContent == null)
            {
                return false;
            }

            int initialCount = _claimContents.Count;
            _claimContents.Dequeue();

            if (initialCount > _claimContents.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //helper
        public ClaimContent GetClaimById(int claimID)
        {
            foreach (ClaimContent content in _claimContents)
            {
                if (content.ClaimID == claimID)
                {
                    return content;
                }
            }
            return null;
        }

        ////helper two
        //public ClaimContent GetHighest(int claimHigh)
        //{
        //    claimHigh getMax(ClaimContent);
        //}

    }
}
