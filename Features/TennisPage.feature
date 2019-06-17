Feature: TennisPage

I navigated to the tennis page and click on and article

 @mytag
Scenario: open an acticle on the tennis page
	Given That I have navigated on the Sports A-Z page
	When I scroll  and click on Tennis
	And I see and click on Zverev & Tsitsipas suffer shock defeats
	Then I see the article main image
	
