Given(/^the calculator has clean memory$/) do
  @result = 0
  @numbersList = []
end

Given(/^I have entered (\d+) into the calculator$/) do |arg1|
  @numbersList << arg1.to_i
end

When(/^I press add$/) do
  @numbersList.each do |number|
      @result = @result + number
  end
end

Then(/^the result should be (\d+) on the screen$/) do |arg1|
  expect(@result).to eql(arg1.to_i)
end
