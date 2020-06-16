package Golang

func finalPrices(prices []int) []int {
	for i, p := range prices {
		for _, q := range prices[i+1:] {
			if q < p {
				prices[i] = p - q
				break
			}
		}
	}
	return prices
}
