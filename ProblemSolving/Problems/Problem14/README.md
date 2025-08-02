# Problem 14: Electricity Usage Billing Optimizer

## 📌 Problem Statement

You are given a list of electricity usage records. Each record includes:
- ✅ **Start time** of usage (`DateTime`)
- ✅ **End time** of usage (`DateTime`)
- ✅ **Power consumption** in kilowatts (kW)

The electricity provider charges based on time of day:
- 💡 **Off-Peak Hours (10:00 PM – 6:00 AM)** → **$0.10 per kWh**
- ⚡ **Peak Hours (6:00 AM – 10:00 PM)** → **$0.20 per kWh**

### 🎯 Goal

Calculate the **accurate total cost** of electricity usage, taking into account:
- Split usage periods between **Peak** and **Off-Peak** hours
- Time intervals spanning across charging boundaries
- Any number of usage records



## 🧮 Algorithm Overview

The billing logic is based on **interval splitting** and **rate application**:

1. **Iterate over each usage record**:
   - Get `start` and `end` `DateTime`.
2. **Split the time span into 1-minute intervals** (fine granularity for precision).
3. For each minute:
   - Check the **hour of the day**:
     - If time is between `6:00 AM` and `10:00 PM` → count as **Peak**
     - Else → count as **Off-Peak**
4. After counting minutes for each category:
   - Convert to **hours**: `minutes / 60.0`
   - Compute energy consumed in each period: `hours × power (kW)`
   - Multiply by appropriate rate:
     - `$0.20/kWh` for Peak
     - `$0.10/kWh` for Off-Peak
5. Accumulate cost and return total.
