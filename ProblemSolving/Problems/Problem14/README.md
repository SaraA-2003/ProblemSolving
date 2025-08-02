# Problem 14: Electricity Usage Billing Optimizer

## Problem Statement

You are given a list of electricity usage records. Each record includes:
- **Start time** of usage (`DateTime`)
- **End time** of usage (`DateTime`)
- **Power consumption** in kilowatts (kW)

The electricity provider charges based on time of day:
- **Off-Peak Hours (10:00 PM – 6:00 AM)** → **$0.10 per kWh**
- **Peak Hours (6:00 AM – 10:00 PM)** → **$0.20 per kWh**

### Goal

Calculate the **accurate total cost** of electricity usage, taking into account:
- Split usage periods between **Peak** and **Off-Peak** hours
- Time intervals spanning across charging boundaries
- Any number of usage records



## Algorithm Overview

This program calculates the total electricity cost based on usage records that include start time, end time, and power consumption in kilowatts. The billing rates differ between peak hours (6:00 AM to 10:00 PM) and off-peak hours (10:00 PM to 6:00 AM).

To ensure accurate billing, the algorithm:

- Splits each usage record’s time interval into peak and off-peak segments if it spans across these periods.

- Calculates the duration spent in each period separately.

- Multiplies each duration by the power consumption and the corresponding rate ($0.20 per kWh during peak, $0.10 per kWh off-peak).

- Sums the partial costs to obtain the total cost for each usage record.

- Aggregates costs from all records to compute the final total billing amount.

This approach guarantees precise cost calculation for any usage pattern within a single day, including intervals that cross between peak and off-peak hours.
